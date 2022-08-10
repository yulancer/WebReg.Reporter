namespace WebReg.Reporter.Domain.Contracts.Interfaces;

public interface IBuilder
{
    Task<IMessage> BuildAsync(ICustomer customer, ICustomerReportData data, IReportTemplate template);
}