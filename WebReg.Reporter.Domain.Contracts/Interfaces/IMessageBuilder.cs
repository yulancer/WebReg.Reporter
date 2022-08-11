using WebReg.Reporter.Domain.Contracts.Enums;

namespace WebReg.Reporter.Domain.Contracts.Interfaces;

public interface IMessageBuilder
{
    Task<IMessage> BuildAsync(ICustomer customer, ICustomerReportData data, IReportTemplate template,
        ChannelType channel);
}