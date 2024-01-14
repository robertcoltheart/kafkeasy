namespace Kafkeasy;

public interface IDeserializer<T>
{
    Task<T> DeserializeAsync(ReadOnlySpan<byte> data, SerializerContext context);
}
