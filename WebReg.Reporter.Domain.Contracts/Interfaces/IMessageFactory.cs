using WebReg.Reporter.Domain.Contracts.Enums;

namespace WebReg.Reporter.Domain.Contracts.Interfaces;

public interface IMessageFactory
{
    Task<IMessage> Create(string address, string body, string header, ChannelType channelType);
}