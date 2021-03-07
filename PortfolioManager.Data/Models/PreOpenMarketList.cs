using System;
using System.Collections.Generic;

#nullable disable

namespace PortfolioManager.Data.Models
{
    public partial class PreOpenMarketList
    {
        public int Identifier { get; set; }
        public int? CompanyRefId { get; set; }
        public string CompanyName { get; set; }
        public DateTime? DateStamp { get; set; }
        public int? PreOpenBuyQty { get; set; }
        public int? PreOpenSellQty { get; set; }
        public decimal? Price { get; set; }
        public bool? Iep { get; set; }
    }
}
