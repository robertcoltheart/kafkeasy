namespace Kafkeasy;

public interface IKafkaProducerBuilder
{
    IKafkaProducerBuilder DefaultTopic(string topic);

    IKafkaProducerBuilder UseMiddleware<T>()
        where T : IMessageMiddleware;
}
