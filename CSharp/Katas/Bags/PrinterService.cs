using Katas.Bags;

namespace Katas.Test.Bags;

public class PrinterService
{
    public static void PrintBag(IBag bag) => Console.Out.WriteLine(bag);

    public static void PrintInventory(List<IBag> inventory) => inventory.ForEach(PrintBag);
}