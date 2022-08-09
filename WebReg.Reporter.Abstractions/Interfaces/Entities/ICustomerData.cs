namespace WebReg.Reporter.Abstractions.Interfaces.Entities;

public interface ICustomerData
{
    ICustomer Customer { get; }

    ICustomerReportData CustomerReportData { get; }
}