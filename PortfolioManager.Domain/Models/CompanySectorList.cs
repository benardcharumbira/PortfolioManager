using System;
using System.Collections.Generic;
using System.Text;

namespace PortfolioManager.Domain.Models
{
    public class CompanySectorList
    {
        public List<string> SectorNames { get; set; }
        public List<int> CompanyTotalsPerSector { get; set; }
    }
}
