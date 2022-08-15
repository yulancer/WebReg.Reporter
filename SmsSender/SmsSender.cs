using WebReg.Reporter.Domain.Contracts.Enums;
using WebReg.Reporter.Domain.Contracts.Interfaces;

namespace SmsSender
{
    public class SmsSender : ISender
    {
        public Task SendAsync(IMessage message)
        {
            throw new NotImplementedException();
        }

        public ChannelType ChannelType => ChannelType.Sms;
    }
}