namespace Katas.Bags;

public enum BagType
{
    BACKPACK,
    CLOTHES,
    HERBS,
    METALS,
    WEAPONS,
    NO_CATEGORY
}

public static class BagTypeExtensions
{
    public static string Category(this BagType type)
    {
        switch (type)
        {
            case BagType.BACKPACK:
                return "backpack";
            case BagType.CLOTHES:
                return "bag_with_clothes_category";
            case BagType.HERBS:
                return "bag_with_herbs_category";
            case BagType.METALS:
                return "bag_with_metals_category";
            case BagType.WEAPONS:
                return "bag_with_weapons_category";
            case BagType.NO_CATEGORY:
                return "bag_with_no_category";
            default:
                throw new ArgumentOutOfRangeException(nameof(type), type, "Not a valid bag category.");
        }
    }
}