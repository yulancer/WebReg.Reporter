namespace WebReg.Reporter.Abstractions.Core.Interfaces;

public interface ICustomer
{
    string Name { get; }

    string Address(IChannel channel);
}