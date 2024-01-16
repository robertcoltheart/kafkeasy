namespace Kafkeasy.Memory;

public class InMemoryMessage<TKey, TValue>
{
    public TKey Key { get; set; }

    public TValue Value { get; set; }
}
