using System.Runtime.Serialization;

namespace Katas.Bags.Items.Exception;

[Serializable]
public class ItemLimitExceededException: System.Exception
{
    public ItemLimitExceededException()
    { }

    protected ItemLimitExceededException(SerializationInfo info, StreamingContext context) 
        : base(info, context)
    { }
}