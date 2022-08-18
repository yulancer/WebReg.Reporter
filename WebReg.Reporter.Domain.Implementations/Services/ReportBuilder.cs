using WebReg.Reporter.Domain.Contracts.Interfaces;

namespace WebReg.Reporter.Domain.Implementations.Services;

public class ReportBuilder : IReportBuilder
{
    private readonly IMessageBuilder _messageBuilder;

    public ReportBuilder(IMessageBuilder messageBuilder)
    {
        _messageBuilder = messageBuilder;
    }

    public async Task<IMessage[]> GetMessagesAsync(IReport report, IReportParams reportParams)
    {
        var template = await report.GetTemplateAsync();
        var data = await report.GetDataAsync(reportParams);
        var channel = report.Channel;

        var messages = new List<IMessage>(data.CustomerData.Length);

        foreach (var customerData in data.CustomerData)
        {
            var address = customerData.Customer.Address(channel);
            if (!string.IsNullOrWhiteSpace(address))
            {
                var message = await _messageBuilder.BuildAsync(customerData.Customer, customerData.CustomerReportData, template, channel);
                messages.Add(message);
            }
        }

        return messages.ToArray();
    }

}