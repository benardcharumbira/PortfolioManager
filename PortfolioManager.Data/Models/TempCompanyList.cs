using System;
using System.Collections.Generic;

#nullable disable

namespace PortfolioManager.Data.Models
{
    public partial class TempCompanyList
    {
        public string Symbol { get; set; }
        public string NameOfCompany { get; set; }
        public string Series { get; set; }
        public DateTime DateOfListing { get; set; }
        public byte PaidUpValue { get; set; }
        public byte MarketLot { get; set; }
        public string IsinNumber { get; set; }
        public byte FaceValue { get; set; }
    }
}
