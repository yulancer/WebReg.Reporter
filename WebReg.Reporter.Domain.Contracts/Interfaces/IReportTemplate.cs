namespace WebReg.Reporter.Abstractions.Core.Interfaces;

public interface IReportTemplate
{
    IReport Report { get; }

    IChannel Channel { get; }
}