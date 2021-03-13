using System;
using System.Collections.Generic;

#nullable disable

namespace PortfolioManager.Data.Models
{
    public partial class PreOpenMarket
    {
        public int Identifier { get; set; }
        public int? CompanyRefId { get; set; }
        public string CompanyName { get; set; }
        public DateTime? DateStamp { get; set; }
        public decimal? Iep { get; set; }
        public decimal? Atobuy { get; set; }
        public decimal? Atosell { get; set; }
        public int? AtoBuyQty { get; set; }
        public int? AtoSellQty { get; set; }
        public decimal? FinalPrice { get; set; }
        public int? FinalQty { get; set; }
        public int? TotalBuyQty { get; set; }
        public int? TotalSellQty { get; set; }
        public int? TotalTradedVolumn { get; set; }
    }
}
