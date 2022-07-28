using Katas.Bags;

namespace Katas.Test.Bags;

public class PrinterService
{
    public static void PrintBag(IBag bag) => Console.Out.WriteLine(bag);

    public static void PrintInventory(Inventory inventory) => inventory.Bags.ForEach(PrintBag);
}