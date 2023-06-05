using CqrsMediator.Application;
using CqrsMediator.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services
    .AddInfrastructure()
    .AddApplication();

var app = builder.Build();

string basePath = "/api";
app.UsePathBase(basePath);

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint($"{basePath}/swagger/v1/swagger.json", "CqrsMediator.Presentation v1");
        c.DefaultModelsExpandDepth(-1);
    });
}

app.MapControllers();

app.Run();
