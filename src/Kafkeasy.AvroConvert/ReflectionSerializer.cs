using Confluent.Kafka;
using Confluent.SchemaRegistry;
using Confluent.SchemaRegistry.Serdes;
using static SolTechnology.Avro.AvroConvert;

namespace Kafkeasy.AvroConvert;

public class ReflectionSerializer<T> : IAsyncSerializer<T>
{
    private readonly ISchemaRegistryClient schemaRegistry;

    private readonly AvroSerializerConfig? config;

    private readonly SubjectNameStrategyDelegate subjectNameStrategy;

    private readonly string schema;

    public ReflectionSerializer(ISchemaRegistryClient schemaRegistry, AvroSerializerConfig? config = null)
    {
        this.schemaRegistry = schemaRegistry;
        this.config = config;

        subjectNameStrategy = config?.SubjectNameStrategy != null
            ? config.SubjectNameStrategy.Value.ToDelegate()
            : SubjectNameStrategy.Topic.ToDelegate();

        schema = GenerateSchema(typeof(T));
    }

    public Task<byte[]> SerializeAsync(T data, SerializationContext context)
    {
        throw new NotImplementedException();
    }

    private string GetSubject(SerializationContext context)
    {
        return subjectNameStrategy(new SerializationContext(context.Component, context.Topic), "");
    }
}
