using WebReg.Reporter.Abstractions.Core.Interfaces;

namespace WebReg.Reporter.Abstractions.Data.Interfaces;

public interface IReportRepository
{
    Task<IReport[]> Reports(Func<IReport, bool>? predicate = null);
}