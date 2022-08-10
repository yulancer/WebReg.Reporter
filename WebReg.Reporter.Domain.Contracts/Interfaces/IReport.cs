namespace WebReg.Reporter.Abstractions.Core.Interfaces;

public interface IReport
{
    Task<IMessage[]> GetMessagesAsync(IReportData reportData);

    IChannel Channel { get; }
}