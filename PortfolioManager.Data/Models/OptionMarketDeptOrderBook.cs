using System;
using System.Collections.Generic;

#nullable disable

namespace PortfolioManager.Data.Models
{
    public partial class OptionMarketDeptOrderBook
    {
        public int Identifier { get; set; }
        public int? CompanyId { get; set; }
        public string CompanyName { get; set; }
        public decimal? CarryBestBuy { get; set; }
        public decimal? CarryBestSell { get; set; }
        public decimal? CarryLastPrice { get; set; }
        public decimal? PriceBestBuy { get; set; }
        public decimal? PriceBestSell { get; set; }
        public decimal? PriceLastPrice { get; set; }
        public decimal? AnnulaisedVolatility { get; set; }
        public decimal? ClientWisePositionLimit { get; set; }
        public decimal? DailyVolitality { get; set; }
        public decimal? ImpliedVolitality { get; set; }
        public decimal? MarketWisePositionLimit { get; set; }
        public decimal? SettlementPrice { get; set; }
        public int? TotalBuyQuantity { get; set; }
        public int? TotalSellQuantity { get; set; }
        public decimal? ChangeInOpenInterest { get; set; }
        public decimal? MarketLot { get; set; }
        public decimal? OpenInterest { get; set; }
        public decimal? PchangeinOpenInterest { get; set; }
        public decimal? PremiumTurnOver { get; set; }
        public decimal? TradedVolume { get; set; }
        public decimal? Value { get; set; }
        public decimal? Vmap { get; set; }
        public DateTime? StampDate { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public decimal? StrikePrice { get; set; }
    }
}
