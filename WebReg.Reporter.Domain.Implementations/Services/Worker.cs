using System;

using WebReg.Reporter.Domain.Contracts.Interfaces;

namespace WebReg.Reporter.Domain.Implementations.Services;

public class Worker : IWorker
{
    private readonly IReportRepository _reportRepository;
    private readonly IReportBuilder _reportBuilder;
    private readonly ISenderService _senderService;

    public Worker(IReportRepository reportRepository, IReportBuilder reportBuilder, ISenderService senderService)
    {
        _reportRepository = reportRepository;
        _reportBuilder = reportBuilder;
        _senderService = senderService;
    }

    public async Task BuildAndSendReports(IReportParams reportParams, Func<IReport, bool>? predicate = null)
    {
        var reports = await _reportRepository.Reports(predicate);
        foreach (var report in reports)
        {
            await BuildAndSendReport(reportParams, report.ReportId);
        }
    }

    public async Task BuildAndSendReport(IReportParams reportParams, Guid reportId)
    {
        var reports = await _reportRepository.Reports();
        var report = reports.FirstOrDefault(r => r.ReportId == reportId);
        if (report != null)
        {
            var messages = await _reportBuilder.GetMessagesAsync(report, reportParams);
            foreach (var message in messages)
            {
                await _senderService.SendAsync(message);
            }
        }
    }
}