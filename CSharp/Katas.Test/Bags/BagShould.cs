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
        bag.AddItem(Items.Clothes.Leather);
        
        // Assert
        bag.Items.Count.Should().Be(1);
        bag.Items[0].Should().Be(Items.Clothes.Leather);
    }

    [Fact]
    public void ThrowExceptionWhenAddingItemBeyondLimit()
    {
        // Arrange
        var bag = new Backpack
        {
            Items = new List<string>
            {
                Items.Clothes.Leather,
                Items.Clothes.Leather,
                Items.Clothes.Leather,
                Items.Clothes.Leather,
                Items.Clothes.Leather,
                Items.Clothes.Leather,
                Items.Clothes.Leather,
                Items.Clothes.Leather
            }
        };
        var action = () => bag.AddItem(Items.Clothes.Leather);
        
        // Act / Assert
        action.Should().Throw<ItemLimitExceededException>();
    }
}