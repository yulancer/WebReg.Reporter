namespace WebReg.Reporter.Abstractions.Interfaces.Entities;

public interface ICustomer
{
    string Name { get; }

    string Address(IChannel channel);
}