using Katalyst.Bags.Bags;

namespace Katalyst.Bags;

public static class PrinterService
{
    public static void PrintBag(IBag bag) => Console.Out.WriteLine(bag);

    public static void PrintInventory(List<IBag> inventory) => inventory.ForEach(PrintBag);
}