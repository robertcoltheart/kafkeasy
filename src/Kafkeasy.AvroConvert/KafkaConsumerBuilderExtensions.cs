using Kafkeasy.Middleware;

namespace Kafkeasy;

public static class KafkaConsumerBuilderExtensions
{
    public static IKafkaConsumerBuilder AddAvroConvertDeserializer<T>(this IKafkaConsumerBuilder builder)
    {
        builder.UseMiddleware<DeserializerMiddleware<T>>();

        return builder;
    }
}
