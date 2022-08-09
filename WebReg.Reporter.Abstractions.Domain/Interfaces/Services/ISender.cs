using WebReg.Reporter.Abstractions.Core.Interfaces.Entities;

namespace WebReg.Reporter.Abstractions.Domain.Interfaces.Services;

public interface ISender
{
    Task SendAsync(IMessage message, IChannel channel);
}