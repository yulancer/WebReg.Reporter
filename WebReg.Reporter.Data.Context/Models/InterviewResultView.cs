using System;
using System.Collections.Generic;

namespace WebReg.Reporter.Data.Context.Models
{
    public partial class InterviewResultView
    {
        public int? InterviewId { get; set; }
        public string? AnswerValue { get; set; }
        public long? Count { get; set; }
    }
}
