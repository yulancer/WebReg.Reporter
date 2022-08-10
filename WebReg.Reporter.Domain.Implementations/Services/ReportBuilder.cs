using WebReg.Reporter.Domain.Contracts.Interfaces;

namespace WebReg.Reporter.Domain.Implementations.Services;

public class ReportBuilder : IReportBuilder
{
    private readonly ITemplateEngine _templateEngine;

    public ReportBuilder(ITemplateEngine templateEngine)
    {
        _templateEngine = templateEngine;
    }

    public async Task<IMessage[]> GetMessagesAsync(IReport report)
    {
        var template = await report.GetTemplateAsync();
        var data = await report.GetDataAsync();
        var channel = report.Channel;
        var messages = new List<IMessage>(data.CustomerData.Length);

        foreach (var customerData in data.CustomerData)
        {
            var address = customerData.Customer.Address(channel);
            if (!string.IsNullOrWhiteSpace(address))
            {
                var message = await _templateEngine.BuildAsync(customerData.Customer, customerData.CustomerReportData, template);
                messages.Add(message);
            }
        }

        return messages.ToArray();
    }

}