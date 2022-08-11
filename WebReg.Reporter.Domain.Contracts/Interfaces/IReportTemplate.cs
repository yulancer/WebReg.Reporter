namespace WebReg.Reporter.Domain.Contracts.Interfaces;

public interface IReportTemplate
{
    /// <summary>
    /// шаблон тела сообщения.
    /// </summary>
    string BodyTemplate { get; }

    /// <summary>
    /// шаблон заголовка
    /// </summary>
    string HeaderTemplate { get; }
}