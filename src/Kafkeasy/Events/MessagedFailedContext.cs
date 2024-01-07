namespace Kafkeasy.Events;

public class MessagedFailedContext : ResultContext
{
    public MessagedFailedContext(MessageContext context, Exception exception)
        : base(context)
    {
        Exception = exception;
    }

    public Exception Exception { get; }
}
