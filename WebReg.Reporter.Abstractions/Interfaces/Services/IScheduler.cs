namespace WebReg.Reporter.Abstractions.Interfaces.Services;

public interface IScheduler
{
    Task Enqueue();
}