namespace Katas.Bags;

public class Organizer : IOrganizer
{
    public void OrganizeItems(IBag backpack, List<IBag> bags)
    {
        var items = new List<string>();
        items.AddRange(backpack.Items);
        items.AddRange(bags.SelectMany(x => x.Items).ToList());

        backpack.Empty();
        foreach (var bag in bags)
        {
            bag.Empty();
        }
        
        foreach (var item in items)
        {
            if (IsMetal(item))
            {
                var bag = bags.First(x => x.Type == BagType.METALS);

                bag.AddItem(item);
                continue;
            }
            
            backpack.AddItem(item);
        }
        
        foreach (var item in backpack.Items)
        {
            if (IsMetal(item))
            {
                var metalBag = bags.First(x => x.Type == BagType.METALS);
                
                metalBag.AddItem(item);
                backpack.RemoveItem(item);
            }
        }
    }

    private static bool IsClothes(string item) => item is "Leather" or "Linen" or "Silk" or "Wool";
    private static bool IsHerb(string item) => item is "Cherry Blossom" or "Marigold" or "Rose" or "Seaweed";
    private static bool IsMetal(string item) => item is "Copper" or "Gold" or "Iron" or "Silver";
    private static bool IsWeapon(string item) => item is "Axe" or "Dagger" or "Mace" or "Sword";
}