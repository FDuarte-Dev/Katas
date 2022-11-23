namespace Katas.Bags.Bags;

public enum BagType
{
    Backpack,
    Clothes,
    Herbs,
    Metals,
    Weapons,
    NoCategory
}

public static class BagTypeExtensions
{
    public static string Category(this BagType type)
    {
        switch (type)
        {
            case BagType.Backpack:
                return "backpack";
            case BagType.Clothes:
                return "bag_with_clothes_category";
            case BagType.Herbs:
                return "bag_with_herbs_category";
            case BagType.Metals:
                return "bag_with_metals_category";
            case BagType.Weapons:
                return "bag_with_weapons_category";
            case BagType.NoCategory:
                return "bag_with_no_category";
            default:
                throw new ArgumentOutOfRangeException(nameof(type), type, "Not a valid bag category.");
        }
    }
}