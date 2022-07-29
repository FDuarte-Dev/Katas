namespace Katas.Test.GameOfLife;

public class Position
{
    public int x { get; set; }
    public int y { get; set; }

    public Position(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    
    public bool isAdjacentTo(Position other)
    {
        return Math.Abs(x - other.x) <= 1 && 
               Math.Abs(y - other.y) <= 1 &&
               !Equals(other);
    }

    protected bool Equals(Position other)
    {
        return x == other.x && y == other.y;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Position)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(x, y);
    }
}