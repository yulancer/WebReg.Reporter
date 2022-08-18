using WebReg.Reporter.WebApi.Contracts.Dto;

namespace WebReg.Reporter.WebApi.Contracts.Interfaces;

public interface IPresenterService
{
    /// <summary>
    /// все отчёты, зарегистрированные на сервисе.
    /// </summary>
    /// <returns></returns>
    Task<ReportViewDto[]> GetAllReports();

    /// <summary>
    /// запустить создание и рассылку отчёта.
    /// </summary>
    /// <param name="reportId"></param>
    /// <param name="reportParams"></param>
    /// <returns></returns>
    Task RunReport(Guid reportId, ReportParamsDto reportParams);
}