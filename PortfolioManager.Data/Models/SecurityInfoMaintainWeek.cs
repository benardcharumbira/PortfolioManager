using System;
using System.Collections.Generic;

#nullable disable

namespace PortfolioManager.Data.Models
{
    public partial class SecurityInfoMaintainWeek
    {
        public int Identifier { get; set; }
        public int? CompanyRefId { get; set; }
        public string CompanyName { get; set; }
        public DateTime? DateStamp { get; set; }
        public string BoardStatus { get; set; }
        public string ClassOfShare { get; set; }
        public bool? Derivatives { get; set; }
        public decimal? FaceValue { get; set; }
        public string IssuedCap { get; set; }
        public string SessionNo { get; set; }
        public string Slb { get; set; }
        public string Surveillance { get; set; }
        public string TradingSegment { get; set; }
        public string TradingStatus { get; set; }
    }
}
