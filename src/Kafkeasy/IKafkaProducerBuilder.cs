using Microsoft.Extensions.DependencyInjection;

namespace Kafkeasy;

public interface IKafkaProducerBuilder
{
    IServiceCollection Services { get; }

    IKafkaProducerBuilder DefaultTopic(string topic);

    IKafkaProducerBuilder UseMiddleware<T>()
        where T : IMessageMiddleware;
}
