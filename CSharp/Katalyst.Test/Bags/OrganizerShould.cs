using FluentAssertions;
using Katalyst.Bags;
using Katalyst.Bags.Bags;
using Katalyst.Bags.Bags.Impl;
using Katalyst.Bags.Items;

namespace Katalyst.Test.Bags;

[Collection("Bags")]
public class OrganizerShould
{
    private static readonly Organizer Organizer = new ();
    
    [Fact]
    public void SendItemsToCorrectBag()
    {
        // Arrange
        var backpack = new Backpack()
        {
            Items = new List<string>()
            {
                Items.Clothes.Leather,
                Items.Herbs.Marigold,
                Items.Metals.Iron,
                Items.Weapons.Axe
            }
        };
        var bags = new List<IBag>()
        {
            new ClothesBag(),
            new HerbBag(),
            new MetalBag(),
            new WeaponBag()
        };

        // Act
        Organizer.OrganizeItems(backpack, bags);
        
        // Assert
        backpack.Items.Should().HaveCount(0);

        var clothesBag = bags[0];
        clothesBag.Items.Should().HaveCount(1);
        clothesBag.Items[0].Should().Be(Items.Clothes.Leather);
        
        var herbBag = bags[1];
        herbBag.Items.Should().HaveCount(1);
        herbBag.Items[0].Should().Be(Items.Herbs.Marigold);
        
        var metalBag = bags[2];
        metalBag.Items.Should().HaveCount(1);
        metalBag.Items[0].Should().Be(Items.Metals.Iron);
        
        var weaponBag = bags[3];
        weaponBag.Items.Should().HaveCount(1);
        weaponBag.Items[0].Should().Be(Items.Weapons.Axe);
    }
    
    [Fact]
    public void SendItemsUpToLimit()
    {
        // Arrange
        var backpack = new Backpack()
        {
            Items = new List<string>()
            {
                Items.Clothes.Leather,
                Items.Clothes.Leather,
                Items.Clothes.Leather,
                Items.Clothes.Leather,
                Items.Clothes.Leather
            }
        };
        var bags = new List<IBag>()
        {
            new ClothesBag()
        };
        
        // Act
        Organizer.OrganizeItems(backpack, bags);
        
        // Assert
        backpack.Items.Should().HaveCount(1);
        backpack.Items[0].Should().Be(Items.Clothes.Leather);
        

        var clothesBag = bags[0];
        clothesBag.Items.Should().HaveCount(clothesBag.Limit);
        clothesBag.Items.Should().OnlyContain(x => x == Items.Clothes.Leather);
    }
    
    [Fact]
    public void SendItemsToNextBagOnLimit()
    {
        // Arrange
        var backpack = new Backpack()
        {
            Items = new List<string>()
            {
                Items.Clothes.Leather,
                Items.Clothes.Leather,
                Items.Clothes.Leather,
                Items.Clothes.Leather,
                Items.Clothes.Leather
            }
        };
        var bags = new List<IBag>()
        {
            new ClothesBag(),
            new ClothesBag()
        };
        
        // Act
        Organizer.OrganizeItems(backpack, bags);
        
        // Assert
        backpack.Items.Should().HaveCount(0);

        var firstClothesBag = bags[0];
        firstClothesBag.Items.Should().HaveCount(firstClothesBag.Limit);
        firstClothesBag.Items.Should().OnlyContain(x => x == Items.Clothes.Leather);
        
        var secondClothesBag = bags[1];
        secondClothesBag.Items.Should().HaveCount(1);
        secondClothesBag.Items.Should().OnlyContain(x => x == Items.Clothes.Leather);
    }

    [Fact]
    public void OrganizeAlphabeticallyWithinBags()
    {
        // Arrange
        var backpack = new Backpack()
        {
            Items = new List<string>()
            {
                Items.Clothes.Wool,
                Items.Clothes.Leather,
                Items.Herbs.CherryBlossom
            }
        };
        var bags = new List<IBag>();
        
        // Act
        Organizer.OrganizeItems(backpack, bags);
        
        // Assert
        backpack.Items.Should().HaveCount(3);
        
        backpack.Items[0].Should().Be(Items.Herbs.CherryBlossom);
        backpack.Items[1].Should().Be(Items.Clothes.Leather);
        backpack.Items[2].Should().Be(Items.Clothes.Wool);
    }
}