namespace WebReg.Reporter.Domain.Contracts.Interfaces;

public interface IReportBuilder
{
    Task<IMessage[]> GetMessagesAsync(IReport report, IReportParams reportParams);
}