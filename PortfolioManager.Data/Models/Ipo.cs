using System;
using System.Collections.Generic;

#nullable disable

namespace PortfolioManager.Data.Models
{
    public partial class Ipo
    {
        public int Identifier { get; set; }
        public string CompanyName { get; set; }
        public int? CompanyId { get; set; }
        public decimal? IssueSize { get; set; }
        public string IssueType { get; set; }
        public DateTime? OpenDate { get; set; }
        public DateTime? CloseDate { get; set; }
        public decimal? Price { get; set; }
        public decimal? BidFrom { get; set; }
        public decimal? BidTo { get; set; }
        public string IssueStatus { get; set; }
        public DateTime? StampDate { get; set; }
    }
}
