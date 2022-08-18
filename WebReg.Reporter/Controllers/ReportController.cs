using Microsoft.AspNetCore.Mvc;

using WebReg.Reporter.WebApi.Contracts.Dto;
using WebReg.Reporter.WebApi.Contracts.Interfaces;

namespace WebReg.Reporter.WebApi.Application.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ReportController : ControllerBase
    {

        private readonly ILogger<ReportController> _logger;

        private readonly IPresenterService _presenterService;
        public ReportController(ILogger<ReportController> logger, IPresenterService presenterService)
        {
            _logger = logger;
            _presenterService = presenterService;
        }

        [HttpGet(Name = "GetReports")]
        public async Task<ReportViewDto[]> GetReports()
        {
            return await _presenterService.GetAllReports();
        }

        [HttpGet]
        [Route("{reportId}")]
        public async Task RunReport(Guid reportId, DateTime? from, DateTime? to)
        {
            ReportParamsDto reportParams = new ReportParamsDto() {StartDate = from, EndDate = to};
            await _presenterService.RunReport(reportId, reportParams);
        }
    }
}