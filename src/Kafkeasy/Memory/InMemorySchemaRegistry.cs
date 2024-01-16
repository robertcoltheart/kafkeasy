using Confluent.SchemaRegistry;

namespace Kafkeasy.Memory;

public class InMemorySchemaRegistry : ISchemaRegistryClient
{
    public int MaxCachedSchemas { get; }

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public Task<int> RegisterSchemaAsync(string subject, string avroSchema, bool normalize = false)
    {
        throw new NotImplementedException();
    }

    public Task<int> RegisterSchemaAsync(string subject, Schema schema, bool normalize = false)
    {
        throw new NotImplementedException();
    }

    public Task<int> GetSchemaIdAsync(string subject, string avroSchema, bool normalize = false)
    {
        throw new NotImplementedException();
    }

    public Task<int> GetSchemaIdAsync(string subject, Schema schema, bool normalize = false)
    {
        throw new NotImplementedException();
    }

    public Task<Schema> GetSchemaAsync(int id, string format = null)
    {
        throw new NotImplementedException();
    }

    public Task<RegisteredSchema> LookupSchemaAsync(string subject, Schema schema, bool ignoreDeletedSchemas, bool normalize = false)
    {
        throw new NotImplementedException();
    }

    public Task<RegisteredSchema> GetRegisteredSchemaAsync(string subject, int version)
    {
        throw new NotImplementedException();
    }

    public Task<string> GetSchemaAsync(string subject, int version)
    {
        throw new NotImplementedException();
    }

    public Task<RegisteredSchema> GetLatestSchemaAsync(string subject)
    {
        throw new NotImplementedException();
    }

    public Task<List<string>> GetAllSubjectsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<List<int>> GetSubjectVersionsAsync(string subject)
    {
        throw new NotImplementedException();
    }

    public Task<bool> IsCompatibleAsync(string subject, string avroSchema)
    {
        throw new NotImplementedException();
    }

    public Task<bool> IsCompatibleAsync(string subject, Schema schema)
    {
        throw new NotImplementedException();
    }

    public string ConstructKeySubjectName(string topic, string recordType = null)
    {
        throw new NotImplementedException();
    }

    public string ConstructValueSubjectName(string topic, string recordType = null)
    {
        throw new NotImplementedException();
    }

    public Task<Compatibility> GetCompatibilityAsync(string subject = null)
    {
        throw new NotImplementedException();
    }

    public Task<Compatibility> UpdateCompatibilityAsync(Compatibility compatibility, string subject = null)
    {
        throw new NotImplementedException();
    }
}
