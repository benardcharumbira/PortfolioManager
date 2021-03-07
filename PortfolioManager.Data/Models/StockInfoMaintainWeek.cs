using System;
using System.Collections.Generic;

#nullable disable

namespace PortfolioManager.Data.Models
{
    public partial class StockInfoMaintainWeek
    {
        public int Identifier { get; set; }
        public int? CompanyRefId { get; set; }
        public string CompanyName { get; set; }
        public string IdentifierCode { get; set; }
        public string Industry { get; set; }
        public bool? IsCasec { get; set; }
        public bool? IsDebtSec { get; set; }
        public bool? IsDelisted { get; set; }
        public bool? IsEtfsec { get; set; }
        public bool? IsFnosec { get; set; }
        public bool? IsSlbsec { get; set; }
        public bool? IsSuspended { get; set; }
        public bool? IsTop10 { get; set; }
        public string Isin { get; set; }
        public string Symbol { get; set; }
        public DateTime? DateStamp { get; set; }
    }
}
