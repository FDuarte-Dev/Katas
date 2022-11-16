using FluentAssertions;
using Katas.Bags;

namespace Katas.Test.Bags;

public class OrganizerShould
{
    [Fact]
    public void SendItemsToCorrectBag()
    {
        // Arrange
        var backpack = new Backpack()
        {
            Items = new List<string>()
            {
                "Leather",
                "Marigold",
                "Iron",
                "Axe"
            }
        };
        var bags = new List<IBag>()
        {
            new ClothesBag(),
            new HerbBag(),
            new MetalBag(),
            new WeaponBag()
        };
        var organizer = new Organizer();
        
        // Act
        organizer.OrganizeItems(backpack, bags);
        
        // Assert
        backpack.Items.Should().HaveCount(0);

        var clothesBag = bags[0];
        clothesBag.Items.Should().HaveCount(1);
        clothesBag.Items[0].Should().Be("Leather");
        
        var herbBag = bags[1];
        herbBag.Items.Should().HaveCount(1);
        herbBag.Items[0].Should().Be("Marigold");
        
        var metalBag = bags[2];
        metalBag.Items.Should().HaveCount(1);
        metalBag.Items[0].Should().Be("Iron");
        
        var weaponBag = bags[3];
        weaponBag.Items.Should().HaveCount(1);
        weaponBag.Items[0].Should().Be("Axe");
    }
    
    [Fact]
    public void SendItemsUpToLimit()
    {
        // Arrange
        var backpack = new Backpack()
        {
            Items = new List<string>()
            {
                "Leather",
                "Leather",
                "Leather",
                "Leather",
                "Leather"
            }
        };
        var bags = new List<IBag>()
        {
            new ClothesBag()
        };
        var organizer = new Organizer();
        
        // Act
        organizer.OrganizeItems(backpack, bags);
        
        // Assert
        backpack.Items.Should().HaveCount(1);
        backpack.Items[0].Should().Be("Leather");
        

        var clothesBag = bags[0];
        clothesBag.Items.Should().HaveCount(clothesBag.Limit);
        clothesBag.Items.Should().OnlyContain(x => x == "Leather");
    }
    
    [Fact]
    public void SendItemsToNextBagOnLimit()
    {
        // Arrange
        var backpack = new Backpack()
        {
            Items = new List<string>()
            {
                "Leather",
                "Leather",
                "Leather",
                "Leather",
                "Leather"
            }
        };
        var bags = new List<IBag>()
        {
            new ClothesBag(),
            new ClothesBag()
        };
        var organizer = new Organizer();
        
        // Act
        organizer.OrganizeItems(backpack, bags);
        
        // Assert
        backpack.Items.Should().HaveCount(0);

        var firstClothesBag = bags[0];
        firstClothesBag.Items.Should().HaveCount(firstClothesBag.Limit);
        firstClothesBag.Items.Should().OnlyContain(x => x == "Leather");
        
        var secondClothesBag = bags[1];
        secondClothesBag.Items.Should().HaveCount(1);
        secondClothesBag.Items.Should().OnlyContain(x => x == "Leather");
    }
}