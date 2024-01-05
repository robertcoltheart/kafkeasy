using Kafkeasy.Events;

namespace Kafkeasy;

public interface IKafkaBuilder
{
    KafkaEvents Events { get; set; }

    IKafkaBuilder AddCluster(Action<IKafkaClusterBuilder> configure);
}
