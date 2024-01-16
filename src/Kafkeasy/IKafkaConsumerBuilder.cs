using Microsoft.Extensions.DependencyInjection;

namespace Kafkeasy;

public interface IKafkaConsumerBuilder
{
    IServiceCollection Services { get; }

    IKafkaConsumerBuilder Topic(string topic);

    IKafkaConsumerBuilder Topics(params string[] topics);

    IKafkaConsumerBuilder WithGroupId(string groupId);

    IKafkaConsumerBuilder SetAutoOffsetReset(AutoOffsetReset autoOffsetReset);

    IKafkaConsumerBuilder SetAutoCommitInterval(TimeSpan interval);

    IKafkaConsumerBuilder ManuallyCompleteMessages();

    IKafkaConsumerBuilder UseMiddleware(Type middleware, params object?[] args);

    IKafkaConsumerBuilder UseMiddleware<T>(params object?[] args)
        where T : IMessageMiddleware;
}
