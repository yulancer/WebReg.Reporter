using WebReg.Reporter.Abstractions.Core.Interfaces;

namespace WebReg.Reporter.Abstractions.Domain.Interfaces;

public interface IBuilder
{
    Task<IMessage> BuildAsync(ICustomer customer, ICustomerReportData data, IReportTemplate template);
}