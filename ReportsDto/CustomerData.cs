using WebReg.Reporter.Domain.Contracts.Interfaces;

namespace ReportsDto;

public class CustomerData : ICustomerData
{
    public ICustomer Customer { get; set; }

    public ICustomerReportData CustomerReportData { get; set; }
}