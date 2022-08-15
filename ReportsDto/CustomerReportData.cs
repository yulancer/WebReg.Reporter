using WebReg.Reporter.Domain.Contracts.Interfaces;

namespace WebReg.Reporter.Reports.Contracts;

public class CustomerReportData : ICustomerReportData
{
    public object BodyData { get; set; }

    public object HeaderData { get; set; }
}