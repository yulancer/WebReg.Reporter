using WebReg.Reporter.Domain.Contracts.Enums;
using WebReg.Reporter.Domain.Contracts.Interfaces;

namespace ConsoleSender
{
    /// <summary>
    /// печатаем сообщение в консоли
    /// </summary>
    public class ConsoleSender : ISender
    {
        public Task SendAsync(IMessage message)
        {
            string output = $"Адрес: {message.Address}{Environment.NewLine}" +
                            $"Заголовок:{message.Header}{Environment.NewLine}" +
                            $"Сообщение:{message.Body}";
            Console.WriteLine(output);

            return Task.CompletedTask;
        }

        public ChannelType ChannelType => ChannelType.Console;
    }
}