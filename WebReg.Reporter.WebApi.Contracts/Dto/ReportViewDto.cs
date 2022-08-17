namespace WebReg.Reporter.WebApi.Contracts.Dto;

/// <summary>
/// данные для отображения типа отчета
/// </summary>
public class ReportViewDto
{
    /// <summary>
    /// название отчёта.
    /// </summary>
    public string ReportName { get; set; }

    /// <summary>
    /// для какого канала предназначен
    /// </summary>
    public string ChannelName { get; set; }
}