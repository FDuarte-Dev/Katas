using System.Runtime.Serialization;

namespace Katalyst.Bags.Items.Exception;

[Serializable]
public class ItemLimitExceededException: System.Exception
{
    public ItemLimitExceededException()
    { }

    protected ItemLimitExceededException(SerializationInfo info, StreamingContext context) 
        : base(info, context)
    { }
}