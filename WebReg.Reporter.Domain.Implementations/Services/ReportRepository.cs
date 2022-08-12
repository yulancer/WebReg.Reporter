using Microsoft.Extensions.DependencyInjection;
using WebReg.Reporter.Domain.Contracts.Interfaces;

namespace WebReg.Reporter.Data.Implementations.Services;

public class ReportRepository : IReportRepository
{
    private readonly IServiceProvider _serviceProvider;

    public ReportRepository(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public Task<IReport[]> Reports(Func<IReport, bool>? predicate = null)
    {
        var reports = _serviceProvider.GetServices<IReport>();
        if (predicate != null)
        {
            reports = reports.Where(predicate);
        }

        return Task.FromResult(reports.ToArray());
    }
}