using WebReg.Reporter.Domain.Contracts.ValueObjects;

namespace WebReg.Reporter.Domain.Contracts.Interfaces;

public interface ICustomer
{
    CustomerName Name { get; }

    string Address(IChannel channel);
}