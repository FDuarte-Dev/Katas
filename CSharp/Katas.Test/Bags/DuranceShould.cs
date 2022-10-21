using FluentAssertions;
using Katas.Bags;
using Moq;

namespace Katas.Test.Bags;

public class DuranceShould
{
    private static readonly Mock<IBag> Backpack = new();
    
    [Fact]
    public void BeAbleToFindItems()
    {
        // Arrange
        var durance = new Durance(Backpack.Object);
        
        // Act
        durance.Find("Leather");
        
        // Assert
        Backpack.Verify(mock => mock.AddItem(It.IsAny<string>()), Times.Once);
    }

    [Fact]
    public void BeAbleToAddBags()
    {
        // Arrange
        var durance = new Durance(Backpack.Object);
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
        var durance = new Durance(Backpack.Object);
        
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
}