using WebReg.Reporter.Abstractions.Core.ValueObjects;

namespace WebReg.Reporter.Abstractions.Core.Interfaces;

public interface ICustomer
{
    CustomerName Name { get; }

    string Address(IChannel channel);
}