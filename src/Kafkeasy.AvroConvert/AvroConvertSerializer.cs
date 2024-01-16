namespace Kafkeasy.AvroConvert;

public class AvroConvertSerializer<T> : ISerializer<T>
{
    public Task<byte[]> SerializeAsync(T message, SerializerContext context)
    {
        throw new NotImplementedException();
    }
}
