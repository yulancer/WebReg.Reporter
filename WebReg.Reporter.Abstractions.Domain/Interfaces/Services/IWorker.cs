using WebReg.Reporter.Abstractions.Core.Interfaces.Entities;

namespace WebReg.Reporter.Abstractions.Domain.Interfaces.Services;

public interface IWorker
{
    Task BuildAndSendReports(Func<IReport, bool>? predicate = null);
}