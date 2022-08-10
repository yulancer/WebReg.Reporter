namespace WebReg.Reporter.Domain.Contracts.Interfaces;

public interface IWorker
{
    Task BuildAndSendReports(Func<IReport, bool>? predicate = null);
}