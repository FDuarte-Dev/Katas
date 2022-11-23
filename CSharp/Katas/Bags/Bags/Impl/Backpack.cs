namespace Katas.Bags.Bags.Impl;

public class Backpack : Bag
{
    public Backpack() : base(BagType.Backpack)
    {
        Limit = 8;
    }
}