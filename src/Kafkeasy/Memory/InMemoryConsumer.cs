using Confluent.Kafka;

namespace Kafkeasy.Memory;

public class InMemoryConsumer<TKey, TValue> : IConsumer<TKey, TValue>
{
    public Handle Handle { get; }

    public string Name { get; }

    public string MemberId { get; }

    public List<TopicPartition> Assignment { get; }

    public List<string> Subscription { get; }

    public IConsumerGroupMetadata ConsumerGroupMetadata { get; }

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public int AddBrokers(string brokers)
    {
        throw new NotImplementedException();
    }

    public void SetSaslCredentials(string username, string password)
    {
        throw new NotImplementedException();
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
        throw new NotImplementedException();
    }

    public void Assign(TopicPartition partition)
    {
        throw new NotImplementedException();
    }

    public void Assign(TopicPartitionOffset partition)
    {
        throw new NotImplementedException();
    }

    public void Assign(IEnumerable<TopicPartitionOffset> partitions)
    {
        throw new NotImplementedException();
    }

    public void Assign(IEnumerable<TopicPartition> partitions)
    {
        throw new NotImplementedException();
    }

    public void IncrementalAssign(IEnumerable<TopicPartitionOffset> partitions)
    {
        throw new NotImplementedException();
    }

    public void IncrementalAssign(IEnumerable<TopicPartition> partitions)
    {
        throw new NotImplementedException();
    }

    public void IncrementalUnassign(IEnumerable<TopicPartition> partitions)
    {
        throw new NotImplementedException();
    }

    public void Unassign()
    {
        throw new NotImplementedException();
    }

    public void StoreOffset(ConsumeResult<TKey, TValue> result)
    {
        throw new NotImplementedException();
    }

    public void StoreOffset(TopicPartitionOffset offset)
    {
        throw new NotImplementedException();
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
        throw new NotImplementedException();
    }

    public void Pause(IEnumerable<TopicPartition> partitions)
    {
        throw new NotImplementedException();
    }

    public void Resume(IEnumerable<TopicPartition> partitions)
    {
        throw new NotImplementedException();
    }

    public List<TopicPartitionOffset> Committed(TimeSpan timeout)
    {
        throw new NotImplementedException();
    }

    public List<TopicPartitionOffset> Committed(IEnumerable<TopicPartition> partitions, TimeSpan timeout)
    {
        throw new NotImplementedException();
    }

    public Offset Position(TopicPartition partition)
    {
        throw new NotImplementedException();
    }

    public List<TopicPartitionOffset> OffsetsForTimes(IEnumerable<TopicPartitionTimestamp> timestampsToSearch, TimeSpan timeout)
    {
        throw new NotImplementedException();
    }

    public WatermarkOffsets GetWatermarkOffsets(TopicPartition topicPartition)
    {
        throw new NotImplementedException();
    }

    public WatermarkOffsets QueryWatermarkOffsets(TopicPartition topicPartition, TimeSpan timeout)
    {
        throw new NotImplementedException();
    }

    public void Close()
    {
        throw new NotImplementedException();
    }
}
