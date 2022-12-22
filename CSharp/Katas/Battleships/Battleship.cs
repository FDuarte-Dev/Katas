namespace Katas.Battleships;

public class Battleship
{
    public bool Running { get; set; }

    public void RunGame(string[] args)
    {
        while (Running)
        {
            Running = RunCommand();
        }
    }

    private static bool RunCommand()
    {
        var command = Console.ReadLine();

        // Have a mediator to run the correct command
        throw new NotImplementedException();
    }

    public void AddPlayer()
    {
        throw new NotImplementedException();
    }

    public void Start()
    {
        throw new NotImplementedException();
    }
}