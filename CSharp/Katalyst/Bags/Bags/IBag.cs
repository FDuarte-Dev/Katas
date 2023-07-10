namespace Katalyst.Bags.Bags;

public interface IBag
{
    public List<string> Items { get; set; }
    public BagType Type { get; set; }
    public int Limit { get; init; }

    public void AddItem(string item);
    public void RemoveItem(string item);
    public void Empty();
}