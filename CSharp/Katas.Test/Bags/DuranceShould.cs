using FluentAssertions;
using Katas.Bags;

namespace Katas.Test.Bags;

public class DuranceShould
{
    [Fact]
    public void BeAbleToFindItems()
    {
        // Arrange
        var durance = new Durance();
        
        // Act
        durance.Find("Leather");
        
        // Assert
        durance.Backpack.Items.Count.Should().Be(1);
    }
}