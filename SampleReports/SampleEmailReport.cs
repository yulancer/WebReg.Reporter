using WebReg.Reporter.Domain.Contracts.Enums;
using WebReg.Reporter.Domain.Contracts.Interfaces;
using WebReg.Reporter.Domain.Contracts.ValueObjects;
using WebReg.Reporter.Reports.Contracts;

namespace WebReg.Reporter.Reports.SampleReports;

public class SampleEmailReport : IReport
{
    public Task<IReportTemplate> GetTemplateAsync()
    {
        Template template = new Template
        {
            HeaderTemplate = "Сообщение для пользователя {{ Customer.Name.Name }}",
            BodyTemplate = @" Уважаемый {{ Customer.Name.Name }} 
                Подписка на продукт  {{ Data.ProductName }} оканчивается {{ Data.ExpiryDate }}
            "
        };

        return Task.FromResult<IReportTemplate>(template);
    }

    public Task<IReportData> GetDataAsync()
    {
        var reportData = new ReportData
        {
            CustomerData = new[]
            {
                new CustomerData
                {
                    Customer = new Customer
                    {
                        AddressStr = "test address",
                        Name = new CustomerName
                        {
                            Name = "name"
                        }
                    },
                    CustomerReportData = new CustomerReportData
                    {
                        BodyData = new {ProductName = "test product name", ExpiryDate = DateTime.Today.AddDays(3).ToString("D")}
                    }
                }
            }
        };

        return Task.FromResult<IReportData>(reportData);
    }

    public ChannelType Channel => ChannelType.Email;
}