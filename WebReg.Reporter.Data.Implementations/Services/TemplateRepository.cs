using WebReg.Reporter.Domain.Contracts.Interfaces;

namespace WebReg.Reporter.Data.Implementations.Services;

public class ReportRepository : IReportRepository
{
    public Task<IReport[]> Reports(Func<IReport, bool>? predicate = null)
    {
        throw new NotImplementedException();
    }
}