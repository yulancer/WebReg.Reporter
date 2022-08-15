using WebReg.Reporter.Domain.Contracts.Interfaces;

namespace ReportsDto;

public class CustomerReportData : ICustomerReportData
{
    public object BodyData { get; set; }

    public object HeaderData { get; set; }
}