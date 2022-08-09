using WebReg.Reporter.Abstractions.Core.Interfaces;

namespace WebReg.Reporter.Abstractions.Domain.Interfaces;

public interface IWorker
{
    Task BuildAndSendReports(Func<IReport, bool>? predicate = null);
}