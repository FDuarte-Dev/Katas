using System.Runtime.Serialization;

namespace Katas.Bags.Bags.Exception;

[Serializable]
public class BagLimitReachedException: System.Exception
{
    public BagLimitReachedException()
    { }

    protected BagLimitReachedException(SerializationInfo info, StreamingContext context) 
        : base(info, context)
    { }
}