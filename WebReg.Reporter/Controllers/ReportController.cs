using Microsoft.AspNetCore.Mvc;

using WebReg.Reporter.WebApi.Contracts.Dto;
using WebReg.Reporter.WebApi.Contracts.Interfaces;

namespace WebReg.Reporter.WebApi.Application.Controllers
{
    [ApiController]
    [Route("[controller]")]
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
        public async Task<ReportViewDto[]> Get()
        {
            return await _presenterService.GetAllReports();
        }
    }
}