using System;
using System.Collections.Generic;

#nullable disable

namespace PortfolioManager.Data.Models
{
    public partial class StockMetaDataInfoMaintainWeek
    {
        public int Identifier { get; set; }
        public int? CompanyRefId { get; set; }
        public string CompanyName { get; set; }
        public string Industry { get; set; }
        public string Isinnumber { get; set; }
        public DateTime? DateStamp { get; set; }
        public DateTime? ListingDate { get; set; }
        public string PdSectorInd { get; set; }
        public decimal? PdSectorPe { get; set; }
        public decimal? PdSymbolPe { get; set; }
        public string Series { get; set; }
        public string Status { get; set; }
        public string Symbol { get; set; }
    }
}
