namespace WebReg.Reporter.Domain.Contracts.Interfaces;

public interface IWorker
{
    Task BuildAndSendReports(IReportParams reportParams, Func<IReport, bool>? predicate = null);
    Task BuildAndSendReport(IReportParams reportParams, Guid reportId);
}