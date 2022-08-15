namespace WebReg.Reporter.Domain.Contracts.Interfaces;

public interface ISenderService
{
    Task SendAsync(IMessage message);
}