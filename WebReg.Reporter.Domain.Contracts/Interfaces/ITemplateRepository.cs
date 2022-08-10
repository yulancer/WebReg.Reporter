namespace WebReg.Reporter.Domain.Contracts.Interfaces;

public interface ITemplateRepository
{
    Task<IReportTemplate> GetAsync(IReport report, IChannel channel);
}