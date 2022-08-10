using WebReg.Reporter.Domain.Contracts.Enums;

namespace WebReg.Reporter.Domain.Contracts.Dto;

public class ReportDto
{
    /// <summary>
    /// канал, для которого создан отчёт
    /// </summary>
    public ChannelType Channel { get; set; }

    /// <summary>
    /// название отчёта
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// уникальный ID отчёта
    /// </summary>
    public string ReportId { get; set; }

    /// <summary>
    /// уникальный ID соответствующего шаблона
    /// </summary>
    public string TemplateId { get; set; }
}