using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Kafkeasy.Tests;

public class Framework
{
    [Fact]
    public void Test()
    {
        var services = new ServiceCollection();

        services.AddKafka(builder => builder
            .AddCluster(cluster => cluster
                .WithBrokers("broker1:2098", "broker2:2098")
                .CreateTopic("my_topic")
                .UseAWSIAMSecurity()
                .AddProducer<AvroMessage>(producer => producer
                    .DefaultTopic("my_topic"))
                .AddConsumer(consumer => consumer
                    .Topic("my_topic")
                    .Topics("my_topic")
                    .WithGroupId("group-id")
                    .SetAutoCommitInterval(TimeSpan.FromSeconds(5))
                    .SetAutoOffsetReset(AutoOffsetReset.Earliest)
                    .ManuallyCompleteMessages())
            ));
    }
}
