using Katas.Test.Bags;

namespace Katas.Bags;

public abstract class Bag: IBag
{
    public List<string> Items { get; set; }
    public BagType Type { get; set; }

    protected Bag(BagType type)
    {
        Items = new List<string>();
        Type = type;
    }
    
    public void AddItem(string item)
    {
        Items.Add(item);
    }

    public void RemoveItem(string item)
    {
        Items.Remove(item);
    }

    public void Empty()
    {
        Items = new List<string>();
    }

    public override string ToString()
    {
        return $"{Type.Category()} = " +
               (Items.Count == 0 
                   ? "[]"
                   : $"['{string.Join("', '", Items)}']");
    }
}