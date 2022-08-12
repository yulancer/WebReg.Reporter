using WebReg.Reporter.Domain.Contracts.Interfaces;

namespace WebReg.Reporter.Domain.Implementations.Dto;

public class CustomerData : ICustomerData
{
    public ICustomer Customer { get; set; }

    public ICustomerReportData CustomerReportData { get; set; }
}