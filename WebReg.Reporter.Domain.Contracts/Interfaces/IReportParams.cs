namespace WebReg.Reporter.Domain.Contracts.Interfaces;

public interface IReportParams
{
    /// <summary>
    /// начало отчетного периода
    /// </summary>
    DateTime? StartDate { get; set; }

    /// <summary>
    /// конец отчетного периода
    /// </summary>
    DateTime? EndDate { get; set; }
}