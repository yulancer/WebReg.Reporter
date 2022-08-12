namespace WebReg.Reporter.Domain.Contracts.Interfaces;

public interface ICustomerReportData
{
    /// <summary>
    /// данные для тела сообщения.
    /// </summary>
    object BodyData { get; }

    /// <summary>
    /// данные для заголовка сообщения.
    /// </summary>
    object HeaderData { get; }
}