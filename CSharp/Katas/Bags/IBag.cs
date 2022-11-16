namespace Katas.Bags;

public interface IBag
{
    public List<string> Items { get; set; }
    public BagType Type { get; set; }

    public void AddItem(string item);
    public void RemoveItem(string item);
    public void Empty();
}