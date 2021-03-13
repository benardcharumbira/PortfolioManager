using System;
using System.Collections.Generic;

#nullable disable

namespace PortfolioManager.Data.Models
{
    public partial class BulkDeal
    {
        public int Identifier { get; set; }
        public string ClientName { get; set; }
        public int? CompanyRefId { get; set; }
        public DateTime? StampDate { get; set; }
        public decimal? CurrentRate { get; set; }
        public decimal? DealPrice { get; set; }
        public int? DealQty { get; set; }
        public DateTime? DealDate { get; set; }
        public string DealType { get; set; }
        public string ScriptCode { get; set; }
    }
}
