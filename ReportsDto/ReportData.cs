using WebReg.Reporter.Domain.Contracts.Interfaces;

namespace WebReg.Reporter.Reports.Contracts;

public class ReportData : IReportData
{
    public ICustomerData[] CustomerData { get; set; }
}