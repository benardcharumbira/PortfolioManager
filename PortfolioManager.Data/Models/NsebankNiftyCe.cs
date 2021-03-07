using System;
using System.Collections.Generic;

#nullable disable

namespace PortfolioManager.Data.Models
{
    public partial class NsebankNiftyCe
    {
        public int Identifier { get; set; }
        public decimal? IndexRate { get; set; }
        public DateTime? DateStamped { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public decimal? StrikePrice { get; set; }
        public decimal? AskPrice { get; set; }
        public int? AskQty { get; set; }
        public decimal? BidPrice { get; set; }
        public int? BidQty { get; set; }
        public decimal? Change { get; set; }
        public decimal? OpenInterestChange { get; set; }
        public decimal? ImpliedVolatility { get; set; }
        public decimal? LastPrice { get; set; }
        public decimal? OpenInterest { get; set; }
        public decimal? PChange { get; set; }
        public decimal? PChangeinOpenInterest { get; set; }
        public int? TotalBuyQuantity { get; set; }
        public int? TotalSellQuantity { get; set; }
        public int? TotalTradedVolume { get; set; }
        public decimal? UnderlyingValue { get; set; }
    }
}
