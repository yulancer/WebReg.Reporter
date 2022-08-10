using WebReg.Reporter.Abstractions.Core.Interfaces;

namespace WebReg.Reporter.Abstractions.Domain.Interfaces;

public interface ISender
{
    Task SendAsync(IMessage message, IChannel channel);
}