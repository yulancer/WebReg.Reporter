namespace WebReg.Reporter.Domain.Contracts.Interfaces;

public interface IReport
{
    Task<IReportTemplate> GetTemplateAsync();
    Task<IReportData> GetDataAsync();
    IChannel Channel { get; }
}