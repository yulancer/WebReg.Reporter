using Fluid;
using WebReg.Reporter.Domain.Contracts.Interfaces;

namespace WebReg.Reporter.Adapters.TemplateEngine
{
    public class FluidTemplateEngine : ITemplateEngine
    {
        private static readonly FluidParser Parser = new();

        public string Parse(string templateStr, object? data, ICustomer customer)
        {
            if (Parser.TryParse(templateStr, out var template, out var error))
            {
                var model = new { Data = data, Customer = customer };
                var context = new TemplateContext(model);

                context.Options.MemberAccessStrategy.Register(typeof(ICustomer));
                context.Options.MemberAccessStrategy.Register(model.GetType());
                if (data != null)
                {
                    context.Options.MemberAccessStrategy.Register(data.GetType());
                }

                return template.Render(context);
            }

            throw new Exception($"ошибка в шаблоне: {error}");
        }
    }
}