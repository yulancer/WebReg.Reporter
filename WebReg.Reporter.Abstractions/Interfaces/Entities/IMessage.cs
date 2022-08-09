namespace WebReg.Reporter.Abstractions.Core.Interfaces.Entities;

public interface IMessage
{
    string Address { get; set; }

    string Body { get; set; }

    string Header { get; set; }
}