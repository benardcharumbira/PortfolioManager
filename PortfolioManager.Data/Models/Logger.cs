using System;
using System.Collections.Generic;

#nullable disable

namespace PortfolioManager.Data.Models
{
    public partial class Logger
    {
        public int LogId { get; set; }
        public string FunctionName { get; set; }
        public DateTime? LoggedDate { get; set; }
        public DateTime? LoggerStart { get; set; }
        public DateTime? LoggerEnd { get; set; }
        public string Remarks { get; set; }
        public bool? IsFailed { get; set; }
        public int? LoadedCount { get; set; }
    }
}
