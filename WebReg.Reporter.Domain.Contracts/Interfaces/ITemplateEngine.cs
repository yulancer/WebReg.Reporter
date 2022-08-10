namespace WebReg.Reporter.Domain.Contracts.Interfaces;

public interface ITemplateEngine
{
    Task<IMessage> BuildAsync(ICustomer customer, ICustomerReportData data, IReportTemplate template);
}