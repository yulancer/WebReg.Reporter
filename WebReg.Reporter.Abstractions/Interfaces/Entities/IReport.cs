namespace WebReg.Reporter.Abstractions.Interfaces.Entities;

public interface IReport
{
    Task<IMessage[]> GetMessagesAsync(IReportData reportData);

    IChannel Channel { get; }
}