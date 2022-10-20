using Katas.Test.Bags;

namespace Katas.Bags;

public class Durance
{
    private IBag Backpack { get; }
    
    public Durance(IBag backpack)
    {
        Backpack = backpack;
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
        throw new NotImplementedException();
    }
}