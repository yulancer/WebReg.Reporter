using WebReg.Reporter.Domain.Contracts.Interfaces;

namespace WebReg.Reporter.WebApi.Contracts.Dto;

public class ReportParamsDto : IReportParams
{
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
}