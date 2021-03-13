using System;
using System.Collections.Generic;

#nullable disable

namespace PortfolioManager.Data.Models
{
    public partial class NiftyoptionDerivativesMetaDatum
    {
        public int Identifier { get; set; }
        public int? IndexId { get; set; }
        public string IndexName { get; set; }
        public DateTime? StampDate { get; set; }
        public decimal? Change { get; set; }
        public decimal? ClosePrice { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public decimal? HighPrice { get; set; }
        public string IdentifierText { get; set; }
        public string InstrumentType { get; set; }
        public decimal? LastPrice { get; set; }
        public decimal? LowPrice { get; set; }
        public decimal? NumberofContractTraded { get; set; }
        public decimal? OpenPrice { get; set; }
        public string OptionType { get; set; }
        public decimal? Pchange { get; set; }
        public decimal? PrevClose { get; set; }
        public decimal? StrikePrice { get; set; }
        public decimal? TotalTurnOver { get; set; }
        public decimal? UnderlyingValue { get; set; }
        public decimal? VolumeFreezeQuantity { get; set; }
    }
}
