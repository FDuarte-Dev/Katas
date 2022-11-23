namespace Katas.Bags;

public class Organizer : IOrganizer
{
    public void OrganizeItems(IBag backpack, List<IBag> bags)
    {
        var items = new List<string>();
        items.AddRange(backpack.Items);
        items.AddRange(bags.SelectMany(x => x.Items).ToList());
        items.Sort();

        backpack.Empty();
        foreach (var bag in bags)
        {
            bag.Empty();
        }
        
        foreach (var item in items)
        {
            IBag? bag = null;
            bag = SelectBag(backpack, bags, item, bag);

            bag.AddItem(item);
        }
    }

    private static IBag SelectBag(IBag backpack, IReadOnlyCollection<IBag> bags, string item, IBag? bag)
    {
        if (IsClothes(item))
        {
            bag = bags.FirstOrDefault(x =>
                x.Type == BagType.CLOTHES &&
                x.Items.Count < x.Limit);
        }

        if (IsHerb(item))
        {
            bag = bags.FirstOrDefault(x =>
                x.Type == BagType.HERBS &&
                x.Items.Count < x.Limit);
        }

        if (IsMetal(item))
        {
            bag = bags.FirstOrDefault(x =>
                x.Type == BagType.METALS &&
                x.Items.Count < x.Limit);
        }

        if (IsWeapon(item))
        {
            bag = bags.FirstOrDefault(x =>
                x.Type == BagType.WEAPONS &&
                x.Items.Count < x.Limit);
        }

        bag ??= backpack;
        return bag;
    }

    private static bool IsClothes(string item) => item is "Leather" or "Linen" or "Silk" or "Wool";
    private static bool IsHerb(string item) => item is "Cherry Blossom" or "Marigold" or "Rose" or "Seaweed";
    private static bool IsMetal(string item) => item is "Copper" or "Gold" or "Iron" or "Silver";
    private static bool IsWeapon(string item) => item is "Axe" or "Dagger" or "Mace" or "Sword";
}