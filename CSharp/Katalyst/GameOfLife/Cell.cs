namespace Katalyst.GameOfLife;

public class Cell
{
    public Cell(CellState state)
    {
        State = state;
    }

    public CellState State { get; private set; }

    public void Update(int numberOfLiveNeighbours)
    {
        if (State == CellState.Alive)
        {
            if (Underpopulated(numberOfLiveNeighbours) ||
                Overcrowded(numberOfLiveNeighbours))
            {
                State = CellState.Extinct;
            }
        }
        else
        {
            if (Reproducible(numberOfLiveNeighbours))
            {
                State = CellState.Alive;
            }
        }
    }

    private bool Underpopulated(int numberOfLiveNeighbours) => numberOfLiveNeighbours < 2;
    private bool Overcrowded(int numberOfLiveNeighbours) => numberOfLiveNeighbours > 3;
    private bool Reproducible(int numberOfLiveNeighbours) => numberOfLiveNeighbours == 3;

    protected bool Equals(Cell other)
    {
        return State == other.State;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Cell)obj);
    }

    public override int GetHashCode()
    {
        return (int)State;
    }
}