using WebReg.Reporter.Abstractions.Core.Interfaces;

namespace WebReg.Reporter.Abstractions.Data.Interfaces;

public interface ITemplateRepository
{
    Task<IReportTemplate> GetAsync(IReport report, IChannel channel);
}