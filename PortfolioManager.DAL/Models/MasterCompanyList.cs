using System;
using System.Collections.Generic;

#nullable disable

namespace PortfolioManager.Data.Models
{
    public partial class MasterCompanyList
    {
        public int Identifier { get; set; }
        public string Symbol { get; set; }
        public int? CompanyId { get; set; }
        public string Isinumber { get; set; }
        public string CompanyName { get; set; }
        public int SeriesId { get; set; }
        public DateTime? RegisteredOn { get; set; }
        public int? PaidUpValue { get; set; }
        public int? MarketLot { get; set; }
        public int? FaceValue { get; set; }
        public bool? Isactive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? ExchangeId { get; set; }
        public int? IndexId { get; set; }
        public int? IndustryTypeId { get; set; }
        public decimal? Eps { get; set; }
        public decimal? MarketCapitalValue { get; set; }
        public string MarketCapitalType { get; set; }
        public decimal? TotalAsset { get; set; }
        public int? SectorId { get; set; }
        public string ScriptCode { get; set; }
        public decimal? FirstTradePrice { get; set; }
        public bool? MyPrefer { get; set; }
        public DateTime? ObserveStartDate { get; set; }
        public DateTime? ObserveEndDate { get; set; }

        public virtual MasterStockSeries Series { get; set; }
    }
}
