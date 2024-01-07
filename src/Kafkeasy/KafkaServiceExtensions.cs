using Confluent.Kafka;
using Kafkeasy;

namespace Microsoft.Extensions.DependencyInjection;

public static class KafkaServiceExtensions
{
    public static IServiceCollection AddKafka(this IServiceCollection services, Action<IKafkaBuilder> configure)
    {
        services.AddHostedService<KafkaHostedService>();

        return services;
    }
}
