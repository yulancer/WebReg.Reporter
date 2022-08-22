using AutoMapper;
using Lamar.Microsoft.DependencyInjection;
using WebReg.Reporter.Data.Context;
using WebReg.Reporter.WebApi.Application;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseLamar(registry => registry.IncludeRegistry<ReporterServicesRegistry>());

// Add services to the container.
// builder.Services.AddReporterServices();
builder.Services.AddSingleton(new MapperConfiguration(mc => mc.AddMaps(AppDomain.CurrentDomain.GetAssemblies()))
    .CreateMapper());
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<WebRegContext>(opt =>
{
    
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
