using Katas.Test.Bags;

namespace Katas.Bags;

public abstract class Bag: IBag
{
    public string[] items { get; set; }
    public BagType Type { get; set; }

    protected Bag(BagType type)
    {
        items = Array.Empty<string>();
        Type = type;
    }

    public override string ToString()
    {
        return $"{Type.Category()} = " +
               (items.Length == 0 
                   ? "[]"
                   : $"['{string.Join("', '", items)}']");
    }
}