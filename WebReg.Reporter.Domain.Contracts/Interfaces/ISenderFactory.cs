using WebReg.Reporter.Domain.Contracts.Enums;

namespace WebReg.Reporter.Domain.Contracts.Interfaces;

public interface ISenderFactory
{
    Task<ISender?> Create(ChannelType channelType);
}