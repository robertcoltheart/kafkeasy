namespace Kafkeasy;

public interface IKafkaConsumerBuilder
{
    IKafkaConsumerBuilder Topic(string topic);

    IKafkaConsumerBuilder WithGroupId(string groupId);

    IKafkaConsumerBuilder SetAutoOffsetReset(AutoOffsetReset autoOffsetReset);

    IKafkaConsumerBuilder DisableAutoCommit();

    IKafkaConsumerBuilder DisableAutoOffsetStore();

    IKafkaConsumerBuilder UseMiddleware<T>()
        where T : IMessageMiddleware;
}
