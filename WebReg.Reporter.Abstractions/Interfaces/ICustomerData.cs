namespace WebReg.Reporter.Abstractions.Core.Interfaces;

public interface ICustomerData
{
    ICustomer Customer { get; }

    ICustomerReportData CustomerReportData { get; }
}