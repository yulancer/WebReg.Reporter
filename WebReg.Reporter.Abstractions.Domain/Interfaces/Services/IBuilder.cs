using WebReg.Reporter.Abstractions.Core.Interfaces.Entities;

namespace WebReg.Reporter.Abstractions.Domain.Interfaces.Services;

public interface IBuilder
{
    Task<IMessage> BuildAsync(ICustomer customer, ICustomerReportData data, IReportTemplate template);
}