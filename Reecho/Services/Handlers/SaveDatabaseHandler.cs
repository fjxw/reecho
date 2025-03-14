using Reecho.Abstracts;

namespace Reecho.Services.Handlers;

public class SaveToDatabaseHandler(IServiceProvider provider) : Handler<Vynil>
{
    private readonly PostgreeDbContext _dbContext = provider.GetRequiredService<PostgreeDbContext>();
    
    public override async Task HandleAsync(Vynil request)
    {
        await _dbContext.Vynils.AddAsync(request);
        await _dbContext.SaveChangesAsync();

        Console.WriteLine($"Винил {request.Title}' успешно сохранен");
        await base.HandleAsync(request);
    }
}
