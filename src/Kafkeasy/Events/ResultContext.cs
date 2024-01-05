namespace Kafkeasy.Events;

public abstract class ResultContext
{
    protected ResultContext(MessageContext context)
    {
        Context = context;
    }

    public MessageContext Context { get; }
}
