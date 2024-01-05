using Confluent.Kafka;
using Microsoft.Extensions.Logging;

namespace Kafkeasy.Consume;

internal class Consumer : IDisposable
{
    private readonly ILogger<Consumer> logger;

    private IConsumer<byte[], byte[]>? consumer;

    public Consumer(ILogger<Consumer> logger)
    {
        this.logger = logger;
    }

    public async Task<ConsumeResult<byte[], byte[]>> ConsumeAsync(CancellationToken cancellationToken)
    {
        while (true)
        {
            try
            {
                EnsureConsumer();

                return consumer!.Consume(cancellationToken);
            }
            catch (KafkaException ex) when (ex.Error.IsFatal)
            {
                Close();

                await Task.Delay(5000, cancellationToken);
            }
        }
    }

    public void Dispose()
    {
        Close();
    }

    private void EnsureConsumer()
    {
        var config = new ConsumerConfig();

        var builder = new ConsumerBuilder<byte[], byte[]>(config);
        consumer = builder.Build();
    }

    private void Close()
    {
        consumer?.Close();
        consumer = null;
    }
}
