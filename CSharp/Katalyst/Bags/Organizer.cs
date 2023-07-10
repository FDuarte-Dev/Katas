using Katalyst.Bags.Bags;

namespace Katalyst.Bags;

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
                x.Type == BagType.Clothes &&
                x.Items.Count < x.Limit);
        }

        if (IsHerb(item))
        {
            bag = bags.FirstOrDefault(x =>
                x.Type == BagType.Herbs &&
                x.Items.Count < x.Limit);
        }

        if (IsMetal(item))
        {
            bag = bags.FirstOrDefault(x =>
                x.Type == BagType.Metals &&
                x.Items.Count < x.Limit);
        }

        if (IsWeapon(item))
        {
            bag = bags.FirstOrDefault(x =>
                x.Type == BagType.Weapons &&
                x.Items.Count < x.Limit);
        }

        bag ??= backpack;
        return bag;
    }

    private static bool IsClothes(string item) => item is Items.Items.Clothes.Leather or Items.Items.Clothes.Linen or Items.Items.Clothes.Silk or Items.Items.Clothes.Wool;
    private static bool IsHerb(string item) => item is Items.Items.Herbs.CherryBlossom or Items.Items.Herbs.Marigold or Items.Items.Herbs.Rose or Items.Items.Herbs.Seaweed;
    private static bool IsMetal(string item) => item is Items.Items.Metals.Copper or Items.Items.Metals.Gold or Items.Items.Metals.Iron or Items.Items.Metals.Silver;
    private static bool IsWeapon(string item) => item is Items.Items.Weapons.Axe or Items.Items.Weapons.Dagger or Items.Items.Weapons.Mace or Items.Items.Weapons.Sword;
}