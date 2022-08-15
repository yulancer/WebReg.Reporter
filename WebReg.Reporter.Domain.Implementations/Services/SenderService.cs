using WebReg.Reporter.Domain.Contracts.Interfaces;

namespace WebReg.Reporter.Domain.Implementations.Services;

public class SenderService : ISenderService
{
    private readonly ISenderFactory _senderFactory;

    public SenderService(ISenderFactory senderFactory)
    {
        _senderFactory = senderFactory;
    }

    public async Task SendAsync(IMessage message)
    {
        var sender = await _senderFactory.Create(message.Channel);
        if (sender != null)
        {
            await sender.SendAsync(message);
        }
    }
}