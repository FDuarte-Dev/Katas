using Katas.Bags;

namespace Katas.Test.Bags;

public class PrinterService
{
    public void PrintBag(Backpack bag)
    {
        Console.Out.WriteLine(bag);
    }

    public void PrintDurance(Durance durance)
    {
        throw new NotImplementedException();
    }
}