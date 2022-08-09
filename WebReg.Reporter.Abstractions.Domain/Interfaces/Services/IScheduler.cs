namespace WebReg.Reporter.Abstractions.Domain.Interfaces.Services;

public interface IScheduler
{
    Task Enqueue();
}