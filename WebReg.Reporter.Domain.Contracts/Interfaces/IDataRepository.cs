using WebReg.Reporter.Abstractions.Core.Interfaces;

namespace WebReg.Reporter.Abstractions.Data.Interfaces;

public interface IDataRepository
{
    Task<IReportData> GetAsync(IReport report);
}