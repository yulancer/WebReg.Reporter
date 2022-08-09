namespace WebReg.Reporter.Abstractions.Interfaces.Entities;

public interface IReportTemplate
{
    IReport Report { get; }

    IChannel Channel { get; }
}