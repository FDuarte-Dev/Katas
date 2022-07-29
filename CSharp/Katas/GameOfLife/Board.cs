using Katas.Test.GameOfLife;

namespace Katas.GameOfLife;

public class Board
{
    public Dictionary<Position, Cell> CellsInPosition { get; set; }
    
    public Board(bool[][] configuration)
    {
        CellsInPosition = new Dictionary<Position, Cell>();
        
        for (var i = 0; i < configuration.Length; i++)
        {
            for (var j = 0; j < configuration[i].Length; j++)
            {
                CellsInPosition.Add(new Position(i, j),
                    new Cell(
                        configuration[i][j] ?
                            CellState.Alive :
                            CellState.Extinct));
            }
        }
    }
    
    public void ApplyNextGen()
    {
        var updatedCellsInPosition = new Dictionary<Position, Cell>();

        foreach (var (position, cell) in CellsInPosition)
        {
            cell.Update(GetAliveNeighboursCount(position));
            updatedCellsInPosition.Add(position, cell);
        }

        CellsInPosition = updatedCellsInPosition;
    }

    public int GetAliveNeighboursCount(Position position) =>
        CellsInPosition
            .Where(x => x.Value.State == CellState.Alive)
            .Where(x => x.Key.isAdjacentTo(position))
            .Select(x => x.Value).Count();

    protected bool Equals(Board other)
    {
        var equal = true;
        foreach (var c in CellsInPosition.Keys)
        {
            equal &= CellsInPosition[c].State == other.CellsInPosition[c].State;
        }
        
        return equal;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Board)obj);
    }

    public override int GetHashCode()
    {
        return CellsInPosition.GetHashCode();
    }
}