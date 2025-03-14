using Reecho.Services.Handlers;

namespace Reecho.Services;

public class VinylProcessingService
{
    private readonly IHandler<Vynil> _handlerChain;

    public VinylProcessingService(IServiceProvider serviceProvider)
    {
        var validationHandler = new ValidationHandler();
        var loggingHandler = new LoggingHandler();
        var saveToDbHandler = new SaveToDatabaseHandler(serviceProvider);

        validationHandler
            .SetNext(loggingHandler)
            .SetNext(saveToDbHandler);

        _handlerChain = validationHandler;
    }

    public async Task ProcessAsync(Vynil vinyl)
    {
        await _handlerChain.HandleAsync(vinyl);
    }
}
