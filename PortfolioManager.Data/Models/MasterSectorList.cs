using System;
using System.Collections.Generic;

#nullable disable

namespace PortfolioManager.Data.Models
{
    public partial class MasterSectorList
    {
        public int Identifier { get; set; }
        public int? SectorId { get; set; }
        public string Name { get; set; }
        public string Desciption { get; set; }
        public decimal? MarketCapital { get; set; }
        public int? ExchangeId { get; set; }
    }
}
