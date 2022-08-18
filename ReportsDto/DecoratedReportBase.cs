using WebReg.Reporter.Domain.Common;
using WebReg.Reporter.Domain.Contracts.Enums;
using WebReg.Reporter.Domain.Contracts.Interfaces;

namespace WebReg.Reporter.Reports.Contracts;

public abstract class DecoratedReportBase
{
    public string ReportName => this.GetAttribute<ReportAttribute>()?.ReportName ?? throw new ArgumentNullException(nameof(ReportName));

    public Guid ReportId => this.GetAttribute<ReportAttribute>()?.ReportId ?? throw new ArgumentNullException(nameof(ReportId));
}