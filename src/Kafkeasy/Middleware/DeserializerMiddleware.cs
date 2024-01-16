namespace Kafkeasy.Middleware;

public class DeserializerMiddleware<T> : IMessageMiddleware
{
    private readonly IDeserializer<T> deserializer;

    public DeserializerMiddleware(IDeserializer<T> deserializer)
    {
        this.deserializer = deserializer;
    }

    public async Task InvokeAsync(MessageContext context, MessageDelegate next)
    {
        var message = context.Message.Value as byte[];

        var data = await deserializer.DeserializeAsync(message, new SerializerContext());

        context.Message = new Message(context.Message.Key, data!);

        await next(context);
    }
}
