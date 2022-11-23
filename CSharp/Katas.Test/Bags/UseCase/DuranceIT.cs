using Katas.Bags;

namespace Katas.Test.Bags.UseCase;

[Collection("Bags")]
public class DuranceIT
{
    private static readonly string OrganizedBags =
        "backpack = ['Cherry Blossom', 'Iron', 'Leather', 'Marigold', 'Silk', 'Wool']" + Environment.NewLine +
        "bag_with_metals_category = ['Copper', 'Copper', 'Copper', 'Gold']" + Environment.NewLine;
    
    [Fact]
    public void Story()
    {
        // Arrange
        var output = new StringWriter();
        Console.SetOut(output);
        
        var backpack = new Backpack();
        var organizer = new Organizer();
        var durance = new Durance(backpack, organizer);

        durance.Find(Items.Clothes.Leather);
        durance.Find(Items.Metals.Iron);
        durance.Find(Items.Metals.Copper);
        durance.Find(Items.Herbs.Marigold);
        durance.Find(Items.Clothes.Wool);
        durance.Find(Items.Metals.Gold);
        durance.Find(Items.Clothes.Silk);
        durance.Find(Items.Metals.Copper);

        var metalBag = new MetalBag();
        durance.AddBag(metalBag);

        durance.Find(Items.Metals.Copper);
        durance.Find(Items.Herbs.CherryBlossom);

        // Act
        durance.Organize();

        // Assert
        durance.ShowBags();
        Assert.Equal(OrganizedBags, output.ToString());
    }
}