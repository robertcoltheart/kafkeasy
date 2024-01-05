namespace Kafkeasy;

public interface IKafkaClusterBuilder
{
    IKafkaClusterBuilder WithBrokers(params string[] brokers);

    IKafkaClusterBuilder CreateTopic(string topic, int? replicas = null, int? partitions = null);

    IKafkaClusterBuilder ConfigureSecurity(Action<KafkaSecurityOptions> configureOptions);

    IKafkaClusterBuilder AddConsumer(Action<IKafkaConsumerBuilder> configure);

    IKafkaClusterBuilder AddProducer(string name, Action<IKafkaProducerBuilder> configure);

    IKafkaClusterBuilder AddProducer<T>(Action<IKafkaProducerBuilder> configure);
}
