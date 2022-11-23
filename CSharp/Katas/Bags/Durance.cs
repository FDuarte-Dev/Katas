using Katas.Bags.Bags;
using Katas.Bags.Bags.Exception;
using Katas.Bags.Items.Exception;

namespace Katas.Bags;

public class Durance
{
    private IBag Backpack { get; }
    private IOrganizer Organizer { get; }
    public List<IBag> Bags { get; }
    private int BagLimit { get; }

    public Durance(IBag backpack, IOrganizer organizer)
    {
        Backpack = backpack;
        Organizer = organizer;
        Bags = new List<IBag>();
        BagLimit = 4;
    }

    public void Find(string item)
    {
        try
        {
            Backpack.AddItem(item);
        }
        catch (ItemLimitExceededException)
        {
            foreach (var bag in Bags)
            {
                try
                {
                    bag.AddItem(item);
                    break;
                }
                catch (ItemLimitExceededException)
                {
                    // continue
                }
            }
        }
    }

    public void Organize()
    {
        Organizer.OrganizeItems(Backpack, Bags);
    }

    public void ShowBags()
    {
        PrinterService.PrintBag(Backpack);
        PrinterService.PrintInventory(Bags);
    }

    public void AddBag(IBag bag)
    {
        if (Bags.Count >= BagLimit)
            throw new BagLimitReachedException();
        Bags.Add(bag);
    }
}