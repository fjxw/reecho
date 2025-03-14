namespace Reecho.Abstracts;

public abstract class Handler<T> : IHandler<T>
{
    private IHandler<T>? _nextHandler;

    public IHandler<T> SetNext(IHandler<T> handler)
    {
        _nextHandler = handler;
        return handler;
    }

    public virtual async Task HandleAsync(T request)
    {
        if (_nextHandler != null)
        {
            await _nextHandler.HandleAsync(request);
        }
    }
}

