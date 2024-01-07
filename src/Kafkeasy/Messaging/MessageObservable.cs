namespace Kafkeasy.Messaging;

public class MessageObservable<T> : IObservable<T>
{
    public IDisposable Subscribe(IObserver<T> observer)
    {
        throw new NotImplementedException();
    }
}
