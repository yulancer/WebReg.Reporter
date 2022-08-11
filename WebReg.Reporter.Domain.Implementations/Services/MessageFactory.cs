using WebReg.Reporter.Domain.Contracts.Enums;
using WebReg.Reporter.Domain.Contracts.Interfaces;
using WebReg.Reporter.Domain.Implementations.Dto;

namespace WebReg.Reporter.Domain.Implementations.Services;

public class MessageFactory : IMessageFactory
{
    public Task<IMessage> Create(string address, string body, string header, ChannelType channelType)
    {
        var message = new Message
        {
            Address = address,
            Body = body,
            Header = header,
            Channel = channelType,
        };

        return Task.FromResult<IMessage>(message);
    }
}