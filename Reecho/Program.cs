

using Reecho.Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<PostgreeDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("PostgreSQL")));
builder.Services.AddTransient<IVynilRepository, VynilRepository>();
builder.Services.AddTransient<VinylProcessingService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapVinylEndpoints();

app.Run();
