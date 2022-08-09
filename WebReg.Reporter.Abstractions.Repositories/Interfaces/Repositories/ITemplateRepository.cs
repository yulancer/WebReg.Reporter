using WebReg.Reporter.Abstractions.Core.Interfaces.Entities;

namespace WebReg.Reporter.Abstractions.Data.Interfaces.Repositories;

public interface ITemplateRepository
{
    Task<IReportTemplate> GetAsync(IReport report, IChannel channel);
}