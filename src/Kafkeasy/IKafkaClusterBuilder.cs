using Microsoft.Extensions.DependencyInjection;

namespace Kafkeasy;

public interface IKafkaClusterBuilder
{
    IServiceCollection Services { get; }

    IKafkaClusterBuilder UseInMemoryBroker(bool enabled = true);

    IKafkaClusterBuilder WithBrokers(params string[] brokers);

    IKafkaClusterBuilder CreateTopic(string topic, int? replicas = null, int? partitions = null);

    IKafkaClusterBuilder ConfigureSecurity(Action<KafkaSecurityOptions> configureOptions);

    IKafkaClusterBuilder AddConsumer(Action<IKafkaConsumerBuilder> configure);

    IKafkaClusterBuilder AddProducer(string name, Action<IKafkaProducerBuilder> configure);

    IKafkaClusterBuilder AddProducer<T>(Action<IKafkaProducerBuilder> configure);
}
