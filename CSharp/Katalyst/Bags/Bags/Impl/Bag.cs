using Katalyst.Bags.Items.Exception;

namespace Katalyst.Bags.Bags.Impl;

public abstract class Bag: IBag
{
    public List<string> Items { get; set; }
    public BagType Type { get; set; }
    public int Limit { get; init; }

    protected Bag(BagType type)
    {
        Items = new List<string>();
        Type = type;
        Limit = 4;
    }
    
    public void AddItem(string item)
    {
        if (Items.Count >= Limit)
        {
            throw new ItemLimitExceededException();
        }
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