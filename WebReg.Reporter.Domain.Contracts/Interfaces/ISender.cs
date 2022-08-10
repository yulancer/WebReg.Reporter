namespace WebReg.Reporter.Domain.Contracts.Interfaces;

public interface ISender
{
    Task SendAsync(IMessage message);
}