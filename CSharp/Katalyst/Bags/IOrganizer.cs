using Katalyst.Bags.Bags;

namespace Katalyst.Bags;

public interface IOrganizer
{
    void OrganizeItems(IBag backpack, List<IBag> bags);
}