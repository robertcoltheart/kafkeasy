namespace Kafkeasy;

public interface IMessageProducerAccessor
{
    IMessageProducer Get(string topic);

    IMessageProducer<T> Get<T>(string topic);
}
