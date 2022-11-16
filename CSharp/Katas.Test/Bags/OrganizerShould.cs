using FluentAssertions;
using Katas.Bags;

namespace Katas.Test.Bags;

public class OrganizerShould
{
    [Fact]
    public void SendItemsToCorrectBag()
    {
        // Arrange
        var bag = new Backpack()
        {
            Items = new List<string>()
            {
                "Iron",
                "Leather"
            }
        };
        var bags = new List<IBag>()
        {
            new MetalBag()
        };
        var organizer = new Organizer();
        
        // Act
        organizer.OrganizeItems(bag, bags);
        
        // Assert
        bag.Items.Should().HaveCount(1);
        bag.Items[0].Should().Be("Leather");

        var metalBag = bags[0];
        metalBag.Items.Should().HaveCount(1);
        metalBag.Items[0].Should().Be("Iron");
    }
}