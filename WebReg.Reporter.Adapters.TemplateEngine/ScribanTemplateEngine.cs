using Scriban;

using WebReg.Reporter.Domain.Contracts.Interfaces;

namespace WebReg.Reporter.Adapters.TemplateEngine;

public class ScribanTemplateEngine : ITemplateEngine
{
    public string Parse(string template, object? data, ICustomer customer)
    {
        var temp = Template.Parse(template);
        var result = temp.Render(new { Data = data, Customer = customer });
        return result;
    }
}