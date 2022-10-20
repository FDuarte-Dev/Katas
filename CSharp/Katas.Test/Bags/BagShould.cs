using FluentAssertions;
using Katas.Bags;

namespace Katas.Test.Bags;

public class BagShould
{
    [Fact]
    public void AddItem()
    {
        // Arrange
        var bag = new Backpack();
        
        // Act
        bag.AddItem("Leather");
        
        // Assert
        bag.Items.Count.Should().Be(1);
        bag.Items[0].Should().Be("Leather");
    }
}