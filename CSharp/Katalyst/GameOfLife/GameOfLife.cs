namespace Katalyst.GameOfLife;

public class GameOfLife
{
    public Board Board { get; }
    
    public GameOfLife(bool[][] board)
    {
        Board = new Board(board);
    }

    public void nextGen()
    {
        Board.ApplyNextGen();
    }
}