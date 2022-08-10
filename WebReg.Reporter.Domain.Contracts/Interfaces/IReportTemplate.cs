namespace WebReg.Reporter.Domain.Contracts.Interfaces;

public interface IReportTemplate
{
    IReportBuilder ReportBuilder { get; }

    IChannel Channel { get; }
}