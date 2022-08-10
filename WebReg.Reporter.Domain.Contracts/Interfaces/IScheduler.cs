namespace WebReg.Reporter.Domain.Contracts.Interfaces;

public interface IScheduler
{
    Task Enqueue();
}