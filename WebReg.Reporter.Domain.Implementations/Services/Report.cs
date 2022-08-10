using WebReg.Reporter.Domain.Contracts.Interfaces;

namespace WebReg.Reporter.Domain.Implementations.Services;

public class Report : IReport
{
    private readonly IBuilder _builder;
    private readonly ITemplateRepository _templateRepository;

    public Report(IBuilder builder, ITemplateRepository templateRepository, IChannel channel)
    {
        _builder = builder;
        _templateRepository = templateRepository;
        Channel = channel;
    }

    public async Task<IMessage[]> GetMessagesAsync(IReportData reportData)
    {
        var template = await _templateRepository.GetAsync(this, Channel);

        var messages = new List<IMessage>(reportData.CustomerData.Length);

        foreach (var customerData in reportData.CustomerData)
        {
            var address = customerData.Customer.Address(Channel);
            if (!string.IsNullOrWhiteSpace(address))
            {
                var message = await _builder.BuildAsync(customerData.Customer, customerData.CustomerReportData, template);
                messages.Add(message);
            }
        }

        return messages.ToArray();
    }

    public IChannel Channel { get; }
}