using DotNetEnv;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi;
using tarefa_ronan_1.Infrastructure;
using tarefa_ronan_1.Services;

var builder = WebApplication.CreateBuilder(args);

Env.Load();

var connectionString =
    Environment.GetEnvironmentVariable("CONNECTION_STRING");

builder.Services.AddScoped<ProdutoServices>();

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseMySql(
        connectionString,
        ServerVersion.AutoDetect(connectionString)
    );
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo()
    {
        Title = "API Produtos",
        Version = "v1",
        Description = "API para gerenciamento de produtos armazenados em MySQL no Google Cloud"
    });
});

var app = builder.Build();

app.UseSwagger();

app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "API Produtos V1");
    options.RoutePrefix = string.Empty;
});


app.MapControllers();

app.Run();
