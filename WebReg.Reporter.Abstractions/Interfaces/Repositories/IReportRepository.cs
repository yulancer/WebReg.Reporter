using WebReg.Reporter.Abstractions.Interfaces.Entities;

namespace WebReg.Reporter.Abstractions.Interfaces.Repositories;

public interface IReportRepository
{
    Task<IReport[]> Reports(Func<IReport, bool>? predicate = null);
}