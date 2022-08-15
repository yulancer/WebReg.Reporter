using WebReg.Reporter.Adapters.ScribanTemplateEngine;
using WebReg.Reporter.Adapters.TemplateEngine;
using WebReg.Reporter.Domain.Contracts.Interfaces;
using WebReg.Reporter.Domain.Contracts.ValueObjects;
using WebReg.Reporter.Domain.Implementations.Dto;

namespace WebReg.Reporter.UnitTests
{
    public class ParserTests
    {
        private readonly ITemplateEngine _fluidEngine = new FluidTemplateEngine();

        private readonly ITemplateEngine _scribanEngine = new ScribanTemplateEngine();

        [SetUp]
        public void Setup()
        {
        }

        [TestCase("{{ Data.Value }}", 123)]
        public void SimpleDataTest(string template, object value)
        {
            var result = _fluidEngine.Parse(template, new { Value = value }, null);
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Contains(value.ToString()));
        }

        [TestCase("{{ customer.address_str }} {{ customer.name.name }}", "test@test.com", "customerName")]
        public void SimpleCustomerTest(string template, string email, string name)
        {
            var result = _scribanEngine.Parse(template, null, new Customer { AddressStr = email, Name = new CustomerName {Name = name} });
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Contains(email), "email не найден");
            Assert.IsTrue(result.Contains(name), "имя не найдено");
        }
    }
}