using WebReg.Reporter.Domain.Contracts.Enums;
using WebReg.Reporter.Domain.Contracts.Interfaces;
using WebReg.Reporter.Domain.Contracts.ValueObjects;
using WebReg.Reporter.Reports.Contracts;

namespace WebReg.Reporter.Reports.SampleReports;

/// <summary>
/// Якобы отправка по почте некой рассылки
/// </summary>
[Report("DEABC81A-C4AE-434B-9C5C-C554AF4C2D77", "Якобы отправка по почте некой рассылки")]
public class SampleConsoleReport : DecoratedReportBase, IReport
{
    public Task<IReportTemplate> GetTemplateAsync()
    {
        Template template = new Template
        {
            HeaderTemplate = "Сообщение для пользователя {{ customer.name.name }}",
            BodyTemplate = @" Уважаемый {{ customer.name.name }} 
                Подписка на продукт  {{ data.productname }} оканчивается {{ data.expirydate }}
            "
        };

        return Task.FromResult<IReportTemplate>(template);
    }

    public Task<IReportData> GetDataAsync(IReportParams reportParams)
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

    public ChannelType Channel => ChannelType.Console;
}