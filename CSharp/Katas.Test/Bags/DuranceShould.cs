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
}