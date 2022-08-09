using WebReg.Reporter.Abstractions.Core.Interfaces.Entities;

namespace WebReg.Reporter.Abstractions.Data.Interfaces.Repositories;

public interface IReportRepository
{
    Task<IReport[]> Reports(Func<IReport, bool>? predicate = null);
}