using Microsoft.Extensions.Hosting;

namespace Kafkeasy;

internal class KafkaHostedService : IHostedService
{
    public Task StartAsync(CancellationToken cancellationToken)
    {
        // Configure via fluent or IConfiguration
        // Started hosted service
        // Produce dynamically using IProducer interface
        // ConsumerPool -> Consumer (consume loop) -> Middleware -> Observer/Handler

        throw new NotImplementedException();
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
