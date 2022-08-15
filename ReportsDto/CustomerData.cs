using WebReg.Reporter.Domain.Contracts.Interfaces;

namespace WebReg.Reporter.Reports.Contracts;

public class CustomerData : ICustomerData
{
    public ICustomer Customer { get; set; }

    public ICustomerReportData CustomerReportData { get; set; }
}