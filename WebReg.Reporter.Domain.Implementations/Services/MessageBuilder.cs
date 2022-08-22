using WebReg.Reporter.Domain.Contracts.Enums;
using WebReg.Reporter.Domain.Contracts.Interfaces;

namespace WebReg.Reporter.Domain.Implementations.Services;

public class MessageBuilder : IMessageBuilder
{
    private readonly ITemplateEngine _templateEngine;
    private readonly IMessageFactory _messageFactory;

    public MessageBuilder(ITemplateEngine templateEngine, IMessageFactory messageFactory)
    {
        _templateEngine = templateEngine;
        _messageFactory = messageFactory;
    }

    public async Task<IMessage> BuildAsync(ICustomer customer, ICustomerReportData data, IReportTemplate template, ChannelType channel)
    {
        var bodyTemplate = template.BodyTemplate;
        var headerTemplate = template.HeaderTemplate;

        var bodyData = data?.BodyData;
        var headerData = data?.HeaderData;

        var body = _templateEngine.Parse(bodyTemplate, bodyData, customer);
        var header = _templateEngine.Parse(headerTemplate, headerData, customer);
        var address = customer.Address(channel);

        var message = await _messageFactory.Create(address, body, header, channel);

        return message;
    }
}