using FluentAssertions;
using Katas.GameOfLife;

namespace Katas.Test.GameOfLife;

[Collection("GameOfLife")]
public class BoardShould
{
    private static readonly bool[][] Configuration = 
            {
                new[] { true, true, false },
                new[] { false, true, false },
                new[] { false, false, false }
            };

    private Board board;
    public BoardShould()
    {
        board = new Board(Configuration);
    }

    [Fact]
    public void HaveAliveCellsAccordingToConstructor()
    {
        // Arrange
        var configuration = new bool[][]
        {
            new []{true, true, false},
            new []{false, true, false},
            new []{false, false, false}
        };
        
        // Act
        var board = new Board(configuration);
        
        // Assert
        board.CellsInPosition.Should().HaveCount(9);
        board.CellsInPosition
            .Where(x => x.Value.State == CellState.Alive)
            .Select(x => x.Key)
            .Should()
            .BeEquivalentTo(new List<Position>()
            {
                new Position(0, 0),
                new Position(0, 1),
                new Position(1, 1)
            });
    }

    [Fact]
    public void FindCellsAliveNeighboursCount()
    {
        // Arrange
        var cellPosition = new Position(1, 1);

        // Act
        var aliveNeighboursCount = board.GetAliveNeighboursCount(cellPosition);
        
        // Assert
        aliveNeighboursCount.Should().Be(2);
    }

    [Fact]
    public void ApplyNewGeneration()
    {
        // Act
        board.ApplyNextGen();
        
        // Expect
        var expectedBoard = new bool[][]
        {
            new[] { true, true, false },
            new[] { true, true, false },
            new[] { false, false, false }
        };
        var expected = new Board(expectedBoard);

        // Assert
        Assert.Equal(expected, board);
    }
}