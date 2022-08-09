namespace WebReg.Reporter.Abstractions.Core.Interfaces.Entities;

public interface ICustomer
{
    string Name { get; }

    string Address(IChannel channel);
}