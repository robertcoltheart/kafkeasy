namespace Kafkeasy.Events;

public class MessageCompletedContext : ResultContext
{
    public MessageCompletedContext(MessageContext context)
        : base(context)
    {
    }
}
