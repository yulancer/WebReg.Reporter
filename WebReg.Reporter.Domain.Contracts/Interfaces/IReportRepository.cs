namespace WebReg.Reporter.Domain.Contracts.Interfaces;

public interface IReportRepository
{
    Task<IReport[]> Reports(Func<IReport, bool>? predicate = null);
}