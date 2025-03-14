using Reecho.Services;

namespace Reecho.Endpoints;

public static class VynilEndpoints
{
    public static void MapVinylEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/api/vynils")
            .WithTags("Vynils")
            .WithOpenApi();

        group.MapGet("/all", GetAllVynils);
        group.MapGet("/{id:guid}", GetVynilById);
        group.MapPost("/", AddVynil);
        group.MapPut("/", UpdateVynil);
        group.MapDelete("/{id:guid}", DeleteVynilById);
        group.MapPost("/process", VynilProcessing);

    }

    private static async Task<IResult> VynilProcessing(Vynil vinyl, VinylProcessingService processingService)
    {
        try
        {
            await processingService.ProcessAsync(vinyl); 
            return Results.Ok("Винил обработам успешно");
        }
        catch (Exception ex)
        {
            return Results.BadRequest(ex.Message); 
        }
    }
    
    private static async Task<IResult> GetAllVynils(IVynilRepository repository)
    {
        return Results.Ok(await repository.GetAllVynils());
    }

    private static async Task<IResult> GetVynilById(Guid id, IVynilRepository repository)
    {
        return Results.Ok(await repository.GetVynilById(id));
    }

    private static async Task<IResult> UpdateVynil(Vynil vynil, IVynilRepository repository)
    {
        await repository.UpdateVynil(vynil);
        return Results.NoContent();
    }
    
    private static async Task<IResult> AddVynil(Vynil vynil, IVynilRepository repository)
    {
        await repository.CreateVynil(vynil);
        return Results.Created($"/api/vynils/{vynil.Id}", vynil);
    }

    private static async Task<IResult> DeleteVynilById(Guid id, IVynilRepository repository)
    {
        await repository.DeleteVynil(id);
        return Results.NoContent();
    }
}