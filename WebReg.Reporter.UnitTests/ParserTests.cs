using WebReg.Reporter.Adapters.TemplateEngine;
using WebReg.Reporter.Domain.Contracts.Interfaces;

namespace WebReg.Reporter.UnitTests
{
    public class ParserTests
    {
        private readonly ITemplateEngine _templateEngine = new FluidTemplateEngine();

        [SetUp]
        public void Setup()
        {
        }

        [TestCase("{{ Data.Value }}", 123)]
        public void SimpleTest(string template, object value)
        {
            var result = _templateEngine.Parse(template, new {Value = value}, null);
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Contains(value.ToString()));
        }
    }
}