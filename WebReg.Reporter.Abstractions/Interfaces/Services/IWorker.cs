using WebReg.Reporter.Abstractions.Interfaces.Entities;

namespace WebReg.Reporter.Abstractions.Interfaces.Services;

public interface IWorker
{
    Task BuildAndSendReports(Func<IReport, bool>? predicate = null);
}