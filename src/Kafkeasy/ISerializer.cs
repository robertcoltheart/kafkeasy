namespace Kafkeasy;

public interface ISerializer<in T>
{
    Task<byte[]> SerializeAsync(T message, SerializerContext context);
}
