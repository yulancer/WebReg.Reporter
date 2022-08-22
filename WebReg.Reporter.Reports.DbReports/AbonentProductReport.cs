using Microsoft.EntityFrameworkCore;
using WebReg.Reporter.Data.Context;
using WebReg.Reporter.Domain.Contracts.Enums;
using WebReg.Reporter.Domain.Contracts.Interfaces;
using WebReg.Reporter.Domain.Contracts.ValueObjects;
using WebReg.Reporter.Reports.Contracts;

namespace WebReg.Reporter.Reports.DbReports
{
    /// <summary>
    /// отчет по реальной базе абонентов
    /// </summary>
    [Report("C8D55FCE-2667-4054-A6E5-91791453E53A", "отчет по реальной базе абонентов")]
    public class AbonentProductReport : DecoratedReportBase, IReport
    {
        private readonly WebRegContext _context;

        public AbonentProductReport(WebRegContext context)
        {
            _context = context;
        }

        public Task<IReportTemplate> GetTemplateAsync()
        {
            Template template = new Template
            {
                HeaderTemplate = "Сообщение для пользователя {{ customer.name.name }}",
                BodyTemplate = @" Уважаемый {{ customer.name.name }} 
            "
            };

            return Task.FromResult<IReportTemplate>(template);
        }

        public async Task<IReportData> GetDataAsync(IReportParams reportParams)
        {
            var abonents = await _context.RoAbonents.Select(ra => new {ra.Email, ra.ShortName}).Take(10).ToArrayAsync();

            var customers = new List<CustomerData>();
            foreach (var abonent in abonents)
            {
                Customer customer = new Customer
                {
                    AddressStr = abonent.Email ?? string.Empty,
                    Name = new CustomerName() {Name = abonent.ShortName}
                };

                customers.Add(new CustomerData(){Customer = customer});
            }

            var data = new ReportData() { CustomerData = customers.ToArray() };
            return data;
        }

        public ChannelType Channel => ChannelType.Console;
    }
}