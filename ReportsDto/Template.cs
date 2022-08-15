using WebReg.Reporter.Domain.Contracts.Interfaces;

namespace ReportsDto;

public class Template : IReportTemplate
{
    public string? BodyTemplate { get; set; }
    public string? HeaderTemplate { get; set; }
}