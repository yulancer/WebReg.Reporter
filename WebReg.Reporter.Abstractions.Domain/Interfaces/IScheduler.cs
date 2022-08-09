namespace WebReg.Reporter.Abstractions.Domain.Interfaces;

public interface IScheduler
{
    Task Enqueue();
}