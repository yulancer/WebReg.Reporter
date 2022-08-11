using WebReg.Reporter.Adapters.TemplateEngine;
using WebReg.Reporter.Data.Implementations.Services;
using WebReg.Reporter.Domain.Contracts.Interfaces;
using WebReg.Reporter.Domain.Implementations.Services;

namespace WebReg.Reporter;

public static class Helper
{
    public static IServiceCollection AddReporterServices(this IServiceCollection services)
    {
        services.AddScoped<IWorker, Worker>();
        services.AddScoped<IReportBuilder, ReportBuilder>();
        services.AddScoped<IMessageFactory, MessageFactory>();
        services.AddScoped<IMessageBuilder, MessageBuilder>();

        services.AddScoped<IReportRepository, ReportRepository>();
        services.AddScoped<ITemplateEngine, FluidTemplateEngine>();
        services.AddScoped<ISender, Sender>();

        return services;
    }
}