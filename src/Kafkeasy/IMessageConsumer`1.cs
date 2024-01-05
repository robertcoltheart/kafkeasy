namespace Kafkeasy;

public interface IMessageConsumer<out T> : IMessageConsumer
{
    IObservable<T> Observe();
}
