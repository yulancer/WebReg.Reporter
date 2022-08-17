using WebReg.Reporter.WebApi.Contracts.Dto;

namespace WebReg.Reporter.WebApi.Contracts.Interfaces;

public interface IPresenterService
{
    /// <summary>
    /// все отчёты, зарегистрированные на сервисе.
    /// </summary>
    /// <returns></returns>
    Task<ReportViewDto[]> GetAllReports();
}