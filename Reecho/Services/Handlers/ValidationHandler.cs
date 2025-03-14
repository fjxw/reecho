using Reecho.Abstracts;

namespace Reecho.Services.Handlers;

public class ValidationHandler : Handler<Vynil>
{
    public override async Task HandleAsync(Vynil request)
    {
        if (string.IsNullOrEmpty(request.Title))
        {
            throw new ArgumentException("Отсутствует название");
        }

        Console.WriteLine("Валидация данных завершена");
        await base.HandleAsync(request);
    }
}
