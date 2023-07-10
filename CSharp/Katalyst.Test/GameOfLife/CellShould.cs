using FluentAssertions;
using Katalyst.GameOfLife;

namespace Katalyst.Test.GameOfLife;

[Collection("GameOfLife")]
public class CellShould
{
    [Fact]
    public void GoExtinctWhenItHasLessThanTwoLiveNeighbours()
    {
        // Arrange
        var cell = new Cell(CellState.Alive);
        
        // Act
        cell.Update(1);

        // Assert
        cell.State.Should().Be(CellState.Extinct);
    }
    
    [Fact]
    public void StayAliveWhenItHasTwoOrThreeNeighbours()
    {
        // Arrange
        var cell = new Cell(CellState.Alive);
        
        // Act
        cell.Update(2);

        // Assert
        cell.State.Should().Be(CellState.Alive);
    }
    
    [Fact]
    public void GoExtinctWhenItHasMoreThanThreeLiveNeighbours()
    {
        // Arrange
        var cell = new Cell(CellState.Alive);
        
        // Act
        cell.Update(4);

        // Assert
        cell.State.Should().Be(CellState.Extinct);
    }
}