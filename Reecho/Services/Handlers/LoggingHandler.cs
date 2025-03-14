using Reecho.Abstracts;

namespace Reecho.Services.Handlers;

public class LoggingHandler : Handler<Vynil>
{
    public override async Task HandleAsync(Vynil request)
    {
        Console.WriteLine($"Обработка винила '{request.Title}'");
        await base.HandleAsync(request);
    }
}
