using WebReg.Reporter.Abstractions.Interfaces.Entities;

namespace WebReg.Reporter.Abstractions.Interfaces.Services;

public interface IBuilder
{
    Task<IMessage> BuildAsync(ICustomer customer, ICustomerReportData data, IReportTemplate template);
}