namespace Kafkeasy;

public interface IMessageConsumer
{
    string Name { get; }

    string GroupId { get; }

    IReadOnlyList<string> Topics { get; }
}
