using WebReg.Reporter.Abstractions.Interfaces.Entities;

namespace WebReg.Reporter.Abstractions.Interfaces.Services;

public interface ISender
{
    Task SendAsync(IMessage message, IChannel channel);
}