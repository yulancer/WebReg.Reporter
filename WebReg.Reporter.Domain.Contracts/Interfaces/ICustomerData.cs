namespace WebReg.Reporter.Domain.Contracts.Interfaces;

public interface ICustomerData
{
    ICustomer Customer { get; }

    ICustomerReportData CustomerReportData { get; }
}