using Katas.Bags;

namespace Katas.Test.Bags.UseCase;

public class DuranceIT
{
    [Fact]
    public void OrganizeFiles()
    {
        var backpack = new Backpack()
        {
            items = new[]{"Leather", "Iron", "Copper", "Marigold", "Wool", "Gold", "Silk", "Copper"}
        };
        var metalBag = new MetalBag();
        
        var durance = new Durance();

        durance.AddBag(backpack);
        durance.AddBag(metalBag);

        durance.Find("Copper");
        durance.Find("Cherry Blossom");

        durance.Organize();

        // TODO: Verification using a logger
        durance.ShowBags();
    }
}