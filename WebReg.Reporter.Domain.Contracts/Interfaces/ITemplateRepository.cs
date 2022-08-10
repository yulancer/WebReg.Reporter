namespace WebReg.Reporter.Domain.Contracts.Interfaces;

public interface ITemplateRepository
{
    Task<IReportTemplate> GetAsync(IReportBuilder reportBuilder, IChannel channel);
}