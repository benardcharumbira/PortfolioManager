using System;
using System.Collections.Generic;

#nullable disable

namespace PortfolioManager.Data.Models
{
    public partial class MasterIndexList
    {
        public int Identifier { get; set; }
        public int IndexId { get; set; }
        public string Name { get; set; }
        public decimal IndexValue { get; set; }
        public int ExchangeId { get; set; }
    }
}
