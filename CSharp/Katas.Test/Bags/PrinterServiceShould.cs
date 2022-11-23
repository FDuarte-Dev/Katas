using Katas.Bags;

namespace Katas.Test.Bags;

public class PrinterServiceShould
{
    private static readonly string BackpackItemString = "backpack = ['Leather', 'Iron', 'Copper', 'Marigold', 'Wool', 'Gold', 'Silk', 'Copper']" + Environment.NewLine;
    private static readonly List<string> Items = new() {"Leather", "Iron", "Copper", "Marigold", "Wool", "Gold", "Silk", "Copper"};
    private static readonly string BackpackAndMetalString = "backpack = []" + Environment.NewLine +
                                                            "bag_with_metals_category = []" + Environment.NewLine;

    [Fact]
    public void PrintBag()
    {
        var output = new StringWriter();
        Console.SetOut(output);
        
        var bag = new Backpack()
        {
            Items = Items
        };

        PrinterService.PrintBag(bag);
        
        Assert.Equal(BackpackItemString, output.ToString());
    }
    
    [Fact]
    public void PrintBags()
    {
        var output = new StringWriter();
        Console.SetOut(output);
        
        var bags = new List<IBag>
        {
            new Backpack(),
            new MetalBag()
        };

        PrinterService.PrintInventory(bags);
        
        Assert.Equal(BackpackAndMetalString, output.ToString());
    }
}