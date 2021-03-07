using System;
using System.Collections.Generic;

#nullable disable

namespace PortfolioManager.Data.Models
{
    public partial class StockPriceInfo
    {
        public int Identifier { get; set; }
        public int? CompanyRefId { get; set; }
        public string CompanyName { get; set; }
        public DateTime? DateStamp { get; set; }
        public decimal? BasePrice { get; set; }
        public decimal? Change { get; set; }
        public decimal? ClosePrice { get; set; }
        public decimal? IntraDayHigh { get; set; }
        public decimal? IntraDayLow { get; set; }
        public decimal? LastPrice { get; set; }
        public string LowerCp { get; set; }
        public decimal? OpenPrice { get; set; }
        public decimal? PChange { get; set; }
        public string PPriceBand { get; set; }
        public decimal? PreviousClose { get; set; }
        public decimal? UpperCp { get; set; }
        public decimal? Vwap { get; set; }
        public decimal? WeeklyHigh { get; set; }
        public DateTime? WeeklyHighDate { get; set; }
        public decimal? WeeklyLow { get; set; }
        public DateTime? WeeklyLowDate { get; set; }
        public int? WeeklyValue { get; set; }
    }
}
