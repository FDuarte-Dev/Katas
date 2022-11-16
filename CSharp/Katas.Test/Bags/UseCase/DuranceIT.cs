using Katas.Bags;

namespace Katas.Test.Bags.UseCase;

public class DuranceIT
{
    private static readonly string OrganizedBags =
        "backpack = ['Cherry Blossom', 'Iron', 'Leather', 'Marigold', 'Silk', 'Wool']" + Environment.NewLine +
        "bag_with_metals_category = ['Copper', 'Copper', 'Copper', 'Gold']";
    
    private readonly StringWriter output;

    public DuranceIT()
    {
        output = new StringWriter();
        Console.SetOut(output);
    }
    
    [Fact]
    public void Story()
    { 
        // Arrange
        var backpack = new Backpack();
        var organizer = new Organizer();
        var durance = new Durance(backpack, organizer);

        durance.Find("Leather");
        durance.Find("Iron");
        durance.Find("Copper");
        durance.Find("Marigold");
        durance.Find("Wool");
        durance.Find("Gold");
        durance.Find("Silk");
        durance.Find("Copper");

        var metalBag = new MetalBag();
        durance.AddBag(metalBag);

        durance.Find("Copper");
        durance.Find("Cherry Blossom");

        // Act
        durance.Organize();
        
        // Assert
        durance.ShowBags();
        Assert.Equal(OrganizedBags, output.ToString());
    }
}