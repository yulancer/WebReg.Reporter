using AutoMapper;
using WebReg.Reporter.Domain.Contracts.Interfaces;
using WebReg.Reporter.WebApi.Contracts.Dto;
using WebReg.Reporter.WebApi.Contracts.Interfaces;

namespace WebReg.Reporter.WebApi.Presenter
{
    public class PresenterService : IPresenterService
    {
        private readonly IReportRepository _reportRepository;
        private readonly IWorker _worker;
        private readonly IMapper _mapper;

        public PresenterService(IReportRepository reportRepository, IMapper mapper, IWorker worker)
        {
            _reportRepository = reportRepository;
            _mapper = mapper;
            _worker = worker;
        }

        public async Task<ReportViewDto[]> GetAllReports()
        {
            var reports = await _reportRepository.Reports();
            var views = _mapper.Map<ReportViewDto[]>(reports);
            return views;
        }

        public async Task RunReport(Guid reportId, ReportParamsDto reportParams)
        {
            await _worker.BuildAndSendReport(reportParams, reportId);
        }
    }
}