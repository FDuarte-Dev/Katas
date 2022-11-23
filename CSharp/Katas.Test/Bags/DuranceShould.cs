using FluentAssertions;
using Katas.Bags;
using Moq;

namespace Katas.Test.Bags;

public class DuranceShould
{
    private static readonly Mock<IOrganizer> Organizer = new();
    
    [Fact]
    public void BeAbleToFindItems()
    {
        // Arrange
        var backpack = new Mock<IBag>();
        var durance = new Durance(backpack.Object, Organizer.Object);
        
        // Act
        durance.Find(Items.Clothes.Leather);
        
        // Assert
        backpack.Verify(mock => mock.AddItem(It.IsAny<string>()), Times.Once);
    }

    [Fact]
    public void BeAbleToAddBags()
    {
        // Arrange
        var backpack = new Mock<IBag>();
        var durance = new Durance(backpack.Object, Organizer.Object);
        var bag = new MetalBag();

        // Act
        durance.AddBag(bag);

        // Assert
        durance.Bags.Count.Should().Be(1);
    }
    
    [Fact]
    public void OnlyAddBagsUpToLimit()
    {
        // Arrange
        var backpack = new Mock<IBag>();
        var durance = new Durance(backpack.Object, Organizer.Object);
        
        var firstBag = new MetalBag();
        var secondBag = new MetalBag();
        var thirdBag = new MetalBag();
        var fourthBag = new MetalBag();
        var fifthBag = new MetalBag();
        
        durance.AddBag(firstBag);
        durance.AddBag(secondBag);
        durance.AddBag(thirdBag);
        durance.AddBag(fourthBag);
        
        // Act
        // Assert
        Assert.Throws<BagLimitReachedException>(() => durance.AddBag(fifthBag));
    }

    [Fact]
    public void AddItemToNextAvailableBag()
    {
        var backpack = new Mock<IBag>();
        backpack.Setup(x => x.AddItem(It.IsAny<string>())).Throws<ItemLimitExceededException>();
        
        var durance = new Durance(backpack.Object, Organizer.Object);

        var bag = new Mock<IBag>();
        durance.AddBag(bag.Object);
        
        // Act
        durance.Find(Items.Clothes.Leather);
        
        // Assert
        bag.Verify(mock => mock.AddItem(It.IsAny<string>()), Times.Once);
    }

    [Fact]
    public void OrganizeBags()
    {
        // Arrange
        var backpack = new Mock<IBag>();
        var durance = new Durance(backpack.Object, Organizer.Object);
        durance.Find(Items.Clothes.Leather);
        Organizer
            .Setup(x => x.OrganizeItems(It.IsAny<IBag>(), It.IsAny<List<IBag>>()))
            .Callback(() => {})
            .Verifiable();
        
        // Act
        durance.Organize();
        
        // Assert
        Organizer.Verify(mock => mock.OrganizeItems(It.IsAny<IBag>(), It.IsAny<List<IBag>>()), Times.Once);
    }
}