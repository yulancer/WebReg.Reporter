namespace WebReg.Reporter.Abstractions.Core.Interfaces.Entities;

public interface ICustomerData
{
    ICustomer Customer { get; }

    ICustomerReportData CustomerReportData { get; }
}