﻿using Confluent.Kafka;

namespace Kafkeasy.Memory;

public class InMemoryProducer<TKey, TValue> : IProducer<TKey, TValue>
{
    public Handle Handle { get; }

    public string Name { get; }

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

    public Task<DeliveryResult<TKey, TValue>> ProduceAsync(string topic, Message<TKey, TValue> message, CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }

    public Task<DeliveryResult<TKey, TValue>> ProduceAsync(TopicPartition topicPartition, Message<TKey, TValue> message, CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }

    public void Produce(string topic, Message<TKey, TValue> message, Action<DeliveryReport<TKey, TValue>> deliveryHandler = null)
    {
        throw new NotImplementedException();
    }

    public void Produce(TopicPartition topicPartition, Message<TKey, TValue> message, Action<DeliveryReport<TKey, TValue>> deliveryHandler = null)
    {
        throw new NotImplementedException();
    }

    public int Poll(TimeSpan timeout)
    {
        throw new NotImplementedException();
    }

    public int Flush(TimeSpan timeout)
    {
        throw new NotImplementedException();
    }

    public void Flush(CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }

    public void InitTransactions(TimeSpan timeout)
    {
        throw new NotImplementedException();
    }

    public void BeginTransaction()
    {
        throw new NotImplementedException();
    }

    public void CommitTransaction(TimeSpan timeout)
    {
        throw new NotImplementedException();
    }

    public void CommitTransaction()
    {
        throw new NotImplementedException();
    }

    public void AbortTransaction(TimeSpan timeout)
    {
        throw new NotImplementedException();
    }

    public void AbortTransaction()
    {
        throw new NotImplementedException();
    }

    public void SendOffsetsToTransaction(IEnumerable<TopicPartitionOffset> offsets, IConsumerGroupMetadata groupMetadata, TimeSpan timeout)
    {
        throw new NotImplementedException();
    }
}
