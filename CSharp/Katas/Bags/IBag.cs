using Katas.Bags;

namespace Katas.Test.Bags;

public interface IBag
{
    public string[] items { get; set; }
    public BagType Type { get; set; }
    }