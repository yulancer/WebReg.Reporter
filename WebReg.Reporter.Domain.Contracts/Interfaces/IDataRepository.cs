namespace WebReg.Reporter.Domain.Contracts.Interfaces;

public interface IDataRepository
{
    Task<IReportData> GetAsync(IReportBuilder reportBuilder);
}