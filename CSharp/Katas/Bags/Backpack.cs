namespace Katas.Bags;

public class Backpack
{
    public string[] items { get; set; }
    public BagType Type { get; private set; }

    public Backpack()
    {
        Type = BagType.backpack;
    }
    
    public override string ToString()
    {
        return $"{Type.ToString()} = ['{string.Join("', '", items)}']";
    }
}