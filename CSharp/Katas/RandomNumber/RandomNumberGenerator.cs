namespace Katas.RandomNumber;

public class RandomNumberGenerator
{
    private Random Random { get; }
    
    public RandomNumberGenerator()
    {
        Random = new Random();
    }

    public virtual int GetInt()
    {
        
        return Random.Next();
    }
}