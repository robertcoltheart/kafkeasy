namespace Kafkeasy;

public interface IMessageConsumerAccessor
{
    IMessageConsumer Get(string topic);

    IMessageConsumer<T> Get<T>(string topic);
}
