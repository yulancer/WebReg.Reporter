namespace WebReg.Reporter.Abstractions.Core.Interfaces.Entities;

public interface IReportTemplate
{
    IReport Report { get; }

    IChannel Channel { get; }
}