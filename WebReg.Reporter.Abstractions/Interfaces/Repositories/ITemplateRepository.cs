using WebReg.Reporter.Abstractions.Interfaces.Entities;

namespace WebReg.Reporter.Abstractions.Interfaces.Repositories;

public interface ITemplateRepository
{
    Task<IReportTemplate> GetAsync(IReport report, IChannel channel);
}