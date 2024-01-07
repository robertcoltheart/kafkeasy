namespace Kafkeasy;

public interface IKafkaConsumerBuilder
{
    IKafkaConsumerBuilder Topic(string topic);

    IKafkaConsumerBuilder Topics(params string[] topics);

    IKafkaConsumerBuilder WithGroupId(string groupId);

    IKafkaConsumerBuilder SetAutoOffsetReset(AutoOffsetReset autoOffsetReset);

    IKafkaConsumerBuilder SetAutoCommitInterval(TimeSpan interval);

    IKafkaConsumerBuilder ManuallyCompleteMessages();

    IKafkaConsumerBuilder UseMiddleware<T>()
        where T : IMessageMiddleware;
}
