using Katas.GameOfLife;

namespace Katas.Test.GameOfLife;

[Collection("GameOfLife")]
public class GameOfLifeShould
{
    [Fact]
    public void TriggerNewGeneration()
    {
        // Arrange
        var board = new bool[][]
        {
            new []{true, true, false},
            new []{false, true, false},
            new []{false, false, false}
        };
        var gameOfLife = new Katas.GameOfLife.GameOfLife(board);
        
        // Act
        gameOfLife.nextGen();

        // Expect
        var expectedBoard = new bool[][]
        {
            new[] { true, true, false },
            new[] { true, true, false },
            new[] { false, false, false }
        };
        var expected = new Board(expectedBoard);

        // Assert
        Assert.Equal(expected, gameOfLife.Board);
    }
}