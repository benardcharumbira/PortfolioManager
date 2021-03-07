using System;
using System.Collections.Generic;

#nullable disable

namespace PortfolioManager.Data.Models
{
    public partial class IndexListHistory
    {
        public int Identifier { get; set; }
        public int IndexRefId { get; set; }
        public DateTime DateStamped { get; set; }
        public decimal? IndexCurrentValue { get; set; }
        public decimal? IndexOpenValue { get; set; }
        public decimal? IndexHighValue { get; set; }
        public decimal? IndexLowValue { get; set; }
        public decimal? IndexCloseValue { get; set; }
    }
}
