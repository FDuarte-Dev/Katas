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

    private static bool IsClothes(string item) => item is Items.Clothes.Leather or Items.Clothes.Linen or Items.Clothes.Silk or Items.Clothes.Wool;
    private static bool IsHerb(string item) => item is Items.Herbs.CherryBlossom or Items.Herbs.Marigold or Items.Herbs.Rose or Items.Herbs.Seaweed;
    private static bool IsMetal(string item) => item is Items.Metals.Copper or Items.Metals.Gold or Items.Metals.Iron or Items.Metals.Silver;
    private static bool IsWeapon(string item) => item is Items.Weapons.Axe or Items.Weapons.Dagger or Items.Weapons.Mace or Items.Weapons.Sword;
}