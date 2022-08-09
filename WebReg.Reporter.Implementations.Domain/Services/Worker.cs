﻿using WebReg.Reporter.Abstractions.Core.Interfaces;
using WebReg.Reporter.Abstractions.Data.Interfaces;
using WebReg.Reporter.Abstractions.Domain.Interfaces;

namespace WebReg.Reporter.Implementations.Domain.Services;

public class Worker : IWorker
{
    private readonly IReportRepository _reportRepository;
    private readonly IDataRepository _dataRepository;
    private readonly ISender _sender;

    public Worker(IReportRepository reportRepository, IDataRepository dataRepository, ISender sender)
    {
        _reportRepository = reportRepository;
        _dataRepository = dataRepository;
        _sender = sender;
    }

    public async Task BuildAndSendReports(Func<IReport, bool>? predicate = null)
    {
        var reports = await _reportRepository.Reports(predicate);
        foreach (var report in reports)
        {
            var reportData = await _dataRepository.GetAsync(report);
            IChannel channel = report.Channel;
            var messages = await report.GetMessagesAsync(reportData);
            foreach (var message in messages)
            {
                await _sender.SendAsync(message, channel);
            }
        }
    }
}