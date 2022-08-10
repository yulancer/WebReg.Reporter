using WebReg.Reporter.Domain.Contracts.Interfaces;

namespace WebReg.Reporter.Domain.Implementations.Services;

public class Worker : IWorker
{
    private readonly IReportRepository _reportRepository;
    private readonly IReportBuilder _reportBuilder;
    private readonly ISender _sender;

    public Worker(IReportRepository reportRepository, IReportBuilder reportBuilder, ISender sender)
    {
        _reportRepository = reportRepository;
        _reportBuilder = reportBuilder;
        _sender = sender;
    }

    public async Task BuildAndSendReports(Func<IReport, bool>? predicate = null)
    {
        var reports = await _reportRepository.Reports(predicate);
        foreach (var report in reports)
        {
            var messages = await _reportBuilder.GetMessagesAsync(report);
            foreach (var message in messages)
            {
                await _sender.SendAsync(message);
            }
        }
    }
}