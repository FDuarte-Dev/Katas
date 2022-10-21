namespace Katas.Bags;

public interface IOrganizer
{
    void OrganizeItems(IBag backpack, List<IBag> bags);
}