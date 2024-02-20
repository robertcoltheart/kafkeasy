using Confluent.Kafka;

namespace Kafkeasy.Memory;

public class InMemoryConsumer<TKey, TValue> : IConsumer<TKey, TValue>
{
    public Handle Handle { get; } = new();

    public string Name => "InMemoryConsumer";

    public string MemberId => string.Empty;

    public List<TopicPartition> Assignment { get; } = new();

    public List<string> Subscription { get; } = new();

    public IConsumerGroupMetadata ConsumerGroupMetadata { get; }

    public void Dispose()
    {
    }

    public int AddBrokers(string brokers)
    {
        return 0;
    }

    public void SetSaslCredentials(string username, string password)
    {
    }

    public ConsumeResult<TKey, TValue> Consume(int millisecondsTimeout)
    {
        throw new NotImplementedException();
    }

    public ConsumeResult<TKey, TValue> Consume(CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }

    public ConsumeResult<TKey, TValue> Consume(TimeSpan timeout)
    {
        throw new NotImplementedException();
    }

    public void Subscribe(IEnumerable<string> topics)
    {
        throw new NotImplementedException();
    }

    public void Subscribe(string topic)
    {
        throw new NotImplementedException();
    }

    public void Unsubscribe()
    {
    }

    public void Assign(TopicPartition partition)
    {
    }

    public void Assign(TopicPartitionOffset partition)
    {
    }

    public void Assign(IEnumerable<TopicPartitionOffset> partitions)
    {
    }

    public void Assign(IEnumerable<TopicPartition> partitions)
    {
    }

    public void IncrementalAssign(IEnumerable<TopicPartitionOffset> partitions)
    {
    }

    public void IncrementalAssign(IEnumerable<TopicPartition> partitions)
    {
    }

    public void IncrementalUnassign(IEnumerable<TopicPartition> partitions)
    {
    }

    public void Unassign()
    {
    }

    public void StoreOffset(ConsumeResult<TKey, TValue> result)
    {
    }

    public void StoreOffset(TopicPartitionOffset offset)
    {
    }

    public List<TopicPartitionOffset> Commit()
    {
        throw new NotImplementedException();
    }

    public void Commit(IEnumerable<TopicPartitionOffset> offsets)
    {
        throw new NotImplementedException();
    }

    public void Commit(ConsumeResult<TKey, TValue> result)
    {
        throw new NotImplementedException();
    }

    public void Seek(TopicPartitionOffset tpo)
    {
    }

    public void Pause(IEnumerable<TopicPartition> partitions)
    {
    }

    public void Resume(IEnumerable<TopicPartition> partitions)
    {
    }

    public List<TopicPartitionOffset> Committed(TimeSpan timeout)
    {
        return new List<TopicPartitionOffset>();
    }

    public List<TopicPartitionOffset> Committed(IEnumerable<TopicPartition> partitions, TimeSpan timeout)
    {
        return new List<TopicPartitionOffset>();
    }

    public Offset Position(TopicPartition partition)
    {
        return new Offset();
    }

    public List<TopicPartitionOffset> OffsetsForTimes(IEnumerable<TopicPartitionTimestamp> timestampsToSearch, TimeSpan timeout)
    {
        return new List<TopicPartitionOffset>();
    }

    public WatermarkOffsets GetWatermarkOffsets(TopicPartition topicPartition)
    {
        return new WatermarkOffsets(new Offset(), new Offset());
    }

    public WatermarkOffsets QueryWatermarkOffsets(TopicPartition topicPartition, TimeSpan timeout)
    {
        return new WatermarkOffsets(new Offset(), new Offset());
    }

    public void Close()
    {
        throw new NotImplementedException();
    }
}
