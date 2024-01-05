namespace Kafkeasy;

public interface IMessageHandler<in T>  : IMessageHandler
{
    Task HandleAsync(MessageContext context, T message);
}
