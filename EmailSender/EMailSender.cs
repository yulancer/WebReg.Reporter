using WebReg.Reporter.Domain.Contracts.Enums;
using WebReg.Reporter.Domain.Contracts.Interfaces;

namespace WebReg.Reporter.Senders.EmailSender
{
    public class EMailSender : ISender
    {
        public Task SendAsync(IMessage message)
        {
            throw new NotImplementedException();
        }

        public ChannelType ChannelType => ChannelType.Email;
    }
}