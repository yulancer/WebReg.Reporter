using WebReg.Reporter.Domain.Contracts.Enums;

namespace WebReg.Reporter.Domain.Contracts.Interfaces;

public interface ISender
{
    Task SendAsync(IMessage message);

    ChannelType ChannelType { get; }
}