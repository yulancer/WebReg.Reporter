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

    public async Task BuildAndSendReports(Func<IReport, bool>? predicate = null)
    {
        var reports = await _reportRepository.Reports(predicate);
        foreach (var report in reports)
        {
            var messages = await _reportBuilder.GetMessagesAsync(report);
            foreach (var message in messages)
            {
                await _senderService.SendAsync(message);
            }
        }
    }
}