using Microsoft.Extensions.DependencyInjection;

namespace Kafkeasy;

public interface IKafkaProducerBuilder
{
    IServiceCollection Services { get; }

    IKafkaProducerBuilder DefaultTopic(string topic);

    IKafkaConsumerBuilder UseMiddleware(Type middleware, params object?[] args);

    IKafkaConsumerBuilder UseMiddleware<T>(params object?[] args)
        where T : IMessageMiddleware;
}
