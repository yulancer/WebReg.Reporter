using WebReg.Reporter.Domain.Contracts.Interfaces;

namespace WebReg.Reporter.Adapters.TemplateEngine
{
    public class FluidTemplateEngine : ITemplateEngine
    {
        public string Parse(string template, object data, ICustomer customer)
        {
            throw new NotImplementedException();
        }
    }
}