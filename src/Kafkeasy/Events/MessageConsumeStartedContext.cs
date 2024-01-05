namespace Kafkeasy.Events;

public class MessageConsumeStartedContext : ResultContext
{
    public MessageConsumeStartedContext(MessageContext context)
        : base(context)
    {
    }
}
