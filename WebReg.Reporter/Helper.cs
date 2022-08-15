﻿using System.Reflection;
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
        services.AddScoped<ISenderService, SenderService>();
        services.AddScoped<ISenderFactory, SenderFactory>();

        services.AddAllImplementations<IReport>();
        services.AddAllImplementations<ISender>();
        services.AddAllImplementations<ITemplateEngine>();

        return services;
    }

    private static IServiceCollection AddAllImplementations<T>(this IServiceCollection services)
    {
        var assemblies = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "*.dll");

        foreach (var assemblyName in assemblies)
        {
            var assembly = Assembly.Load(AssemblyName.GetAssemblyName(assemblyName));

            foreach (var ti in assembly.DefinedTypes)
            {
                if (ti.ImplementedInterfaces.Contains(typeof(T)))
                {
                    services.AddTransient(typeof(T), ti);
                }
            }
        }

        return services;
    }
}