namespace Kafkeasy.Tests;

public class AvroMessageHandler : IMessageHandler<AvroMessage>
{
    public Task HandleAsync(MessageContext context, AvroMessage message)
    {
        context.Complete();

        return Task.CompletedTask;
    }
}
