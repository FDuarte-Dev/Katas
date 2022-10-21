using Katas.Test.Bags;

namespace Katas.Bags;

public class Durance
{
    private IBag Backpack { get; }
    public List<IBag> Bags { get; set; }
    public int BagLimit { get; }

    public Durance(IBag backpack)
    {
        Backpack = backpack;
        Bags = new List<IBag>();
        BagLimit = 4;
    }

    public void Find(string item)
    {
        Backpack.AddItem(item);
    }

    public void Organize()
    {
        throw new NotImplementedException();
    }

    public void ShowBags()
    {
        throw new NotImplementedException();
    }

    public void AddBag(IBag bag)
    {
        if (Bags.Count >= BagLimit)
            throw new BagLimitReachedException();
        Bags.Add(bag);
    }
}