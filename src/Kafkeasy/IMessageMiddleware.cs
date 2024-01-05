namespace Kafkeasy;

public interface IMessageMiddleware
{
    Task InvokeAsync(MessageContext context, MessageDelegate next);
}
