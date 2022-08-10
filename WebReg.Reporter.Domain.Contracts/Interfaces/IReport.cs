namespace WebReg.Reporter.Domain.Contracts.Interfaces;

public interface IReport
{
    Task<IMessage[]> GetMessagesAsync(IReportData reportData);

    IChannel Channel { get; }
}