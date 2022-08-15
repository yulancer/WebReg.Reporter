using WebReg.Reporter.Domain.Contracts.Interfaces;

namespace ReportsDto;

public class ReportData : IReportData
{
    public ICustomerData[] CustomerData { get; set; }
}