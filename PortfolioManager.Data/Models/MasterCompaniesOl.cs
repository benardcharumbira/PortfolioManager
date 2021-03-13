using System;
using System.Collections.Generic;

#nullable disable

namespace PortfolioManager.Data.Models
{
    public partial class MasterCompaniesOl
    {
        public int Id { get; set; }
        public string Symbol { get; set; }
        public string Name { get; set; }
        public int? ExchangeId { get; set; }
        public string ExchangeName { get; set; }
    }
}
