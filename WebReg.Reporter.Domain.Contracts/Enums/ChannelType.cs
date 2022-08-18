using System.ComponentModel.DataAnnotations;

namespace WebReg.Reporter.Domain.Contracts.Enums;

public enum ChannelType
{
    [Display(Name = "Email", Description = "Электронная почта")]
    Email = 1,

    [Display(Name = "Sms", Description = "СМС")]
    Sms = 2,

    [Display(Name = "Push", Description = "Push уведомление")]
    Push = 3,

    [Display(Name = "Telegram", Description = "Бот Telegram")]
    Telegram = 4,

    [Display(Name = "Console", Description = "Вывод в stdio")]
    Console = 5,
}