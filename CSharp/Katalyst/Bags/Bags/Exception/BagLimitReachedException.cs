using System.Runtime.Serialization;

namespace Katalyst.Bags.Bags.Exception;

[Serializable]
public class BagLimitReachedException: System.Exception
{
    public BagLimitReachedException()
    { }

    protected BagLimitReachedException(SerializationInfo info, StreamingContext context) 
        : base(info, context)
    { }
}