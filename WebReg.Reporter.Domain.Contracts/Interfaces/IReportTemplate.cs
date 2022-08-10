namespace WebReg.Reporter.Domain.Contracts.Interfaces;

public interface IReportTemplate
{
    IReport Report { get; }

    IChannel Channel { get; }
}