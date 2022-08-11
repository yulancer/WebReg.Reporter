using WebReg.Reporter.Domain.Contracts.Interfaces;

namespace WebReg.Reporter.Domain.Implementations.Services;

public class Sender : ISender
{
    public Task SendAsync(IMessage message)
    {
        throw new NotImplementedException();
    }
}