using System;
using System.Collections.Generic;

#nullable disable

namespace PortfolioManager.Data.Models
{
    public partial class SectorListHistory
    {
        public int Identifier { get; set; }
        public int SectorRefId { get; set; }
        public DateTime DateStamped { get; set; }
        public decimal? MarketCapital { get; set; }
    }
}
