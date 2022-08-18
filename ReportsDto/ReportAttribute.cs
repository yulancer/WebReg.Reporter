namespace WebReg.Reporter.Reports.Contracts;

[AttributeUsage(AttributeTargets.Class, Inherited = false)]
public class ReportAttribute : Attribute
{
    public ReportAttribute(string reportId, string reportName)
    {
        ReportId = Guid.Parse(reportId);
        ReportName = reportName;
    }

    public Guid ReportId { get; }

    public string ReportName { get; }
}