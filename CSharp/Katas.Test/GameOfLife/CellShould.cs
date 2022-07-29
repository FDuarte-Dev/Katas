using FluentAssertions;
using Katas.GameOfLife;

namespace Katas.Test.GameOfLife;

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