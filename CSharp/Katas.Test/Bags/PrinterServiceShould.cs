using Katas.Bags;

namespace Katas.Test.Bags;

public class PrinterServiceShould
{
    private static readonly string BackpackItemString = "backpack = ['Leather', 'Iron', 'Copper', 'Marigold', 'Wool', 'Gold', 'Silk', 'Copper']" + Environment.NewLine;
    private static readonly string[] Items = {"Leather", "Iron", "Copper", "Marigold", "Wool", "Gold", "Silk", "Copper"};
    private static readonly string BackpackAndMetalString = "backpack = []" + Environment.NewLine +
                                                            "bag_with_metals_category" + Environment.NewLine;

    private readonly StringWriter output;
    private readonly PrinterService printerService;

    public PrinterServiceShould()
    {
        output = new StringWriter();
        Console.SetOut(output);
        
        printerService = new PrinterService();
    }

    [Fact]
    public void PrintBag()
    {
        var bag = new Backpack()
        {
            items = Items
        };

        printerService.PrintBag(bag);
        
        Assert.Equal(BackpackItemString, output.ToString());
    }
    
    [Fact]
    public void PrintDurance()
    {
        var durance = new Durance();

        printerService.PrintDurance(durance);
        
        Assert.Equal(BackpackAndMetalString, output.ToString());
    }
}