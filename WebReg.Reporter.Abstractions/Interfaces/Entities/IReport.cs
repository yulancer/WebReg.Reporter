namespace WebReg.Reporter.Abstractions.Core.Interfaces.Entities;

public interface IReport
{
    Task<IMessage[]> GetMessagesAsync(IReportData reportData);

    IChannel Channel { get; }
}