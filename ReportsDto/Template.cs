using WebReg.Reporter.Domain.Contracts.Interfaces;

namespace WebReg.Reporter.Reports.Contracts;

public class Template : IReportTemplate
{
    public string? BodyTemplate { get; set; }
    public string? HeaderTemplate { get; set; }
}