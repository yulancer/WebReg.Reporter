namespace WebReg.Reporter.Domain.Contracts.Interfaces;

public interface IMessage
{
    string Address { get; set; }

    string Body { get; set; }

    string Header { get; set; }
}