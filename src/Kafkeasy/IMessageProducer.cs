using Confluent.Kafka;

namespace Kafkeasy;

public interface IMessageProducer
{
    string Name { get; }

    Task<DeliveryResult<byte[], byte[]>> ProduceAsync(string topic, object key, object value);

    Task<DeliveryResult<byte[], byte[]>> ProduceAsync(object key, object value);

    void Produce(string topic, object key, object value);

    void Produce(object key, object value);
}
