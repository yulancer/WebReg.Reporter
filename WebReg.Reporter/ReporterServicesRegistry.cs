using AutoMapper;

using Lamar;

using WebReg.Reporter.Domain.Contracts.Interfaces;
using WebReg.Reporter.WebApi.Contracts.Interfaces;

namespace WebReg.Reporter.WebApi.Application;

public class ReporterServicesRegistry : ServiceRegistry
{
    public ReporterServicesRegistry()
    {
        Scan(scanner =>
        {
            scanner.AssembliesAndExecutablesFromApplicationBaseDirectory();

            scanner.AddAllTypesOf<IReport>();
            scanner.AddAllTypesOf<ISender>();
            scanner.AddAllTypesOf<ITemplateEngine>();
            scanner.AddAllTypesOf<IPresenterService>();

            scanner.ExcludeNamespaceContainingType<MapperConfiguration>();

            scanner.AddAllTypesOf<IWorker>(ServiceLifetime.Scoped);
            scanner.AddAllTypesOf<IReportBuilder>(ServiceLifetime.Scoped);
            scanner.AddAllTypesOf<IMessageFactory>(ServiceLifetime.Scoped);
            scanner.AddAllTypesOf<IMessageBuilder>(ServiceLifetime.Scoped);

            scanner.AddAllTypesOf<IReportRepository>(ServiceLifetime.Scoped);
            scanner.AddAllTypesOf<ISenderService>(ServiceLifetime.Scoped);
            scanner.AddAllTypesOf<ISenderFactory>(ServiceLifetime.Scoped);
        });
    }
}