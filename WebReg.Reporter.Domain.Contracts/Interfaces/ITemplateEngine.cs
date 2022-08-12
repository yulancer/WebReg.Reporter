namespace WebReg.Reporter.Domain.Contracts.Interfaces;

/// <summary>
/// движок шаблонов.
/// </summary>
public interface ITemplateEngine
{
    string Parse(string template, object? data, ICustomer customer);
}