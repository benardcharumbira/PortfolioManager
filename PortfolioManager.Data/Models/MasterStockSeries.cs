using System;
using System.Collections.Generic;

#nullable disable

namespace PortfolioManager.Data.Models
{
    public partial class MasterStockSeries
    {
        public MasterStockSeries()
        {
            MasterCompanyLists = new HashSet<MasterCompanyList>();
        }

        public int Identifier { get; set; }
        public string SeriesName { get; set; }

        public virtual ICollection<MasterCompanyList> MasterCompanyLists { get; set; }
    }
}
