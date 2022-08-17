using WebReg.Reporter.Domain.Contracts.Enums;

namespace WebReg.Reporter.Domain.Contracts.Interfaces;

public interface IReport
{
    Task<IReportTemplate> GetTemplateAsync();
    Task<IReportData> GetDataAsync();
    ChannelType Channel { get; }
    string ReportName { get; }
}