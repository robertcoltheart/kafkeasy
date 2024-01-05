namespace Kafkeasy;

public readonly struct Message
{
    public Message(object key, object value)
    {
        Key = key;
        Value = value;
    }

    public object Key { get; }

    public object Value { get; }
}
