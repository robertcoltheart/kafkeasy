namespace Kafkeasy.Events;

public class MessgeStartedContext : ResultContext
{
    public MessgeStartedContext(MessageContext context)
        : base(context)
    {
    }
}
