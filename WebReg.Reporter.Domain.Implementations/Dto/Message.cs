using WebReg.Reporter.Domain.Contracts.Enums;
using WebReg.Reporter.Domain.Contracts.Interfaces;

namespace WebReg.Reporter.Domain.Implementations.Dto;

public class Message : IMessage
{
    public string Address { get; set; }
    public string Body { get; set; }
    public string Header { get; set; }
    public ChannelType Channel { get; set; }
}