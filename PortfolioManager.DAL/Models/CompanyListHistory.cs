using System;
using System.Collections.Generic;

#nullable disable

namespace PortfolioManager.Data.Models
{
    public partial class CompanyListHistory
    {
        public int Identifier { get; set; }
        public int? CompanyRefId { get; set; }
        public DateTime? DateStamped { get; set; }
        public decimal? CurrentPrice { get; set; }
        public decimal? Eps { get; set; }
        public decimal? Dllholding { get; set; }
        public decimal? Fllholding { get; set; }
        public decimal? ForeignPromoter { get; set; }
        public decimal? MarketCapitalValue { get; set; }
        public decimal? NetProfitMargin { get; set; }
        public decimal? OperatingProfitMargin { get; set; }
        public decimal? PromoterHolding { get; set; }
        public decimal? Revenue { get; set; }
        public decimal? TotalAssest { get; set; }
        public decimal? Volume { get; set; }
        public string ScriptCode { get; set; }
        public decimal? PreOpen { get; set; }
        public decimal? PreClose { get; set; }
        public decimal? PreChangePercentage { get; set; }
        public int? PreColor { get; set; }
        public decimal? Open { get; set; }
        public decimal? Close { get; set; }
        public decimal? High { get; set; }
        public decimal? Low { get; set; }
    }
}
