using WebReg.Reporter.Abstractions.Core.Interfaces.Entities;

namespace WebReg.Reporter.Abstractions.Data.Interfaces.Repositories;

public interface IDataRepository
{
    Task<IReportData> GetAsync(IReport report);
}