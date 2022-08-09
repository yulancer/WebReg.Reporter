using WebReg.Reporter.Abstractions.Interfaces.Entities;

namespace WebReg.Reporter.Abstractions.Interfaces.Repositories;

public interface IDataRepository
{
    Task<IReportData> GetAsync(IReport report);
}