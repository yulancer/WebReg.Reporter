using WebReg.Reporter.Domain.Contracts.Interfaces;

namespace WebReg.Reporter.Domain.Implementations.Dto;

public class ReportData : IReportData
{
    public ICustomerData[] CustomerData { get; set; }
}