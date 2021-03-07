using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PortfolioManager.Data.Models
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BankNiftyOptionMarketDeptOrderBook> BankNiftyOptionMarketDeptOrderBooks { get; set; }
        public virtual DbSet<BankniftyoptionDerivativesMetaDatum> BankniftyoptionDerivativesMetaData { get; set; }
        public virtual DbSet<BulkDeal> BulkDeals { get; set; }
        public virtual DbSet<CompanyListHistory> CompanyListHistories { get; set; }
        public virtual DbSet<IndexListHistory> IndexListHistories { get; set; }
        public virtual DbSet<IndustryListHistory> IndustryListHistories { get; set; }
        public virtual DbSet<Ipo> Ipos { get; set; }
        public virtual DbSet<Logger> Loggers { get; set; }
        public virtual DbSet<MasterCompaniesOl> MasterCompaniesOls { get; set; }
        public virtual DbSet<MasterCompanyList> MasterCompanyLists { get; set; }
        public virtual DbSet<MasterExchangeList> MasterExchangeLists { get; set; }
        public virtual DbSet<MasterIndexList> MasterIndexLists { get; set; }
        public virtual DbSet<MasterIndustryList> MasterIndustryLists { get; set; }
        public virtual DbSet<MasterSectorList> MasterSectorLists { get; set; }
        public virtual DbSet<MasterStockSeries> MasterStockSeries { get; set; }
        public virtual DbSet<NiftyOptionMarketDeptOrderBook> NiftyOptionMarketDeptOrderBooks { get; set; }
        public virtual DbSet<NiftyoptionDerivativesMetaDatum> NiftyoptionDerivativesMetaData { get; set; }
        public virtual DbSet<NsebankNiftyCe> NsebankNiftyCes { get; set; }
        public virtual DbSet<NsebankNiftyPe> NsebankNiftyPes { get; set; }
        public virtual DbSet<NseniftyCe> NseniftyCes { get; set; }
        public virtual DbSet<NseniftyPe> NseniftyPes { get; set; }
        public virtual DbSet<OptionDerivativesMetaDatum> OptionDerivativesMetaData { get; set; }
        public virtual DbSet<OptionMarketDeptOrderBook> OptionMarketDeptOrderBooks { get; set; }
        public virtual DbSet<OptionType> OptionTypes { get; set; }
        public virtual DbSet<PreOpenMarket> PreOpenMarkets { get; set; }
        public virtual DbSet<PreOpenMarketList> PreOpenMarketLists { get; set; }
        public virtual DbSet<SectorListHistory> SectorListHistories { get; set; }
        public virtual DbSet<SecurityInfoMaintainWeek> SecurityInfoMaintainWeeks { get; set; }
        public virtual DbSet<StockInfoMaintainWeek> StockInfoMaintainWeeks { get; set; }
        public virtual DbSet<StockMetaDataInfoMaintainWeek> StockMetaDataInfoMaintainWeeks { get; set; }
        public virtual DbSet<StockOptionsCe> StockOptionsCes { get; set; }
        public virtual DbSet<StockOptionsPe> StockOptionsPes { get; set; }
        public virtual DbSet<StockPriceInfo> StockPriceInfos { get; set; }
        public virtual DbSet<TempCompanyList> TempCompanyLists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PortfolioManager");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<BankNiftyOptionMarketDeptOrderBook>(entity =>
            {
                entity.HasKey(e => e.Identifier);

                entity.ToTable("BankNiftyOptionMarketDeptOrderBook");

                entity.Property(e => e.AnnulaisedVolatility).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CarryBestBuy).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CarryBestSell).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CarryLastPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ChangeInOpenInterest).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ClientWisePositionLimit).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DailyVolitality).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ExpiryDate).HasColumnType("date");

                entity.Property(e => e.ImpliedVolitality).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IndexId).HasColumnName("IndexID");

                entity.Property(e => e.IndexName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.MarketLot).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.MarketWisePositionLimit).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.OpenInterest).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PchangeinOpenInterest)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("PChangeinOpenInterest");

                entity.Property(e => e.PremiumTurnOver).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PriceBestBuy).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PriceBestSell).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PriceLastPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SettlementPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.StampDate).HasColumnType("date");

                entity.Property(e => e.StrikePrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TradedVolume).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Value).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Vmap)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("VMAP");
            });

            modelBuilder.Entity<BankniftyoptionDerivativesMetaDatum>(entity =>
            {
                entity.HasKey(e => e.Identifier);

                entity.ToTable("BANKNIFTYOptionDerivativesMetaData");

                entity.Property(e => e.Change).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ClosePrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ExpiryDate).HasColumnType("date");

                entity.Property(e => e.HighPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IdentifierText)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IndexId).HasColumnName("IndexID");

                entity.Property(e => e.IndexName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.InstrumentType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.LowPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.NumberofContractTraded).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.OpenPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.OptionType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pchange)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("PChange");

                entity.Property(e => e.PrevClose).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.StampDate).HasColumnType("date");

                entity.Property(e => e.StrikePrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TotalTurnOver).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.UnderlyingValue).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.VolumeFreezeQuantity).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<BulkDeal>(entity =>
            {
                entity.HasKey(e => e.Identifier);

                entity.ToTable("BulkDeal");

                entity.Property(e => e.ClientName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyRefId).HasColumnName("CompanyRefID");

                entity.Property(e => e.CurrentRate).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DealDate).HasColumnType("date");

                entity.Property(e => e.DealPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DealType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ScriptCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StampDate).HasColumnType("date");
            });

            modelBuilder.Entity<CompanyListHistory>(entity =>
            {
                entity.HasKey(e => e.Identifier);

                entity.ToTable("CompanyListHistory");

                entity.Property(e => e.Close).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CompanyRefId).HasColumnName("CompanyRefID");

                entity.Property(e => e.CurrentPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DateStamped).HasColumnType("date");

                entity.Property(e => e.Dllholding)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("DLLHolding");

                entity.Property(e => e.Eps)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("EPS");

                entity.Property(e => e.Fllholding)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("FLLHolding");

                entity.Property(e => e.ForeignPromoter).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.High).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Low).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.MarketCapitalValue).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.NetProfitMargin).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Open).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.OperatingProfitMargin).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PreChangePercentage).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PreClose).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PreOpen).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PromoterHolding).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Revenue).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ScriptCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalAssest).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Volume).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<IndexListHistory>(entity =>
            {
                entity.HasKey(e => e.Identifier);

                entity.ToTable("IndexListHistory");

                entity.Property(e => e.DateStamped).HasColumnType("date");

                entity.Property(e => e.IndexCloseValue).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IndexCurrentValue).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IndexHighValue).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IndexLowValue).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IndexOpenValue).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IndexRefId).HasColumnName("IndexRefID");
            });

            modelBuilder.Entity<IndustryListHistory>(entity =>
            {
                entity.HasKey(e => e.Identifier);

                entity.ToTable("IndustryListHistory");

                entity.Property(e => e.DateStamped).HasColumnType("date");

                entity.Property(e => e.IndustryRefId).HasColumnName("IndustryRefID");

                entity.Property(e => e.MarketCapital).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<Ipo>(entity =>
            {
                entity.HasKey(e => e.Identifier);

                entity.ToTable("IPO");

                entity.Property(e => e.BidFrom).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.BidTo).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CloseDate).HasColumnType("date");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.IssueSize).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IssueStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IssueType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OpenDate).HasColumnType("date");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.StampDate).HasColumnType("date");
            });

            modelBuilder.Entity<Logger>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("Logger");

                entity.Property(e => e.FunctionName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsFailed).HasDefaultValueSql("('FALSE')");

                entity.Property(e => e.LoggedDate).HasColumnType("date");

                entity.Property(e => e.LoggerEnd).HasColumnType("date");

                entity.Property(e => e.LoggerStart).HasColumnType("date");

                entity.Property(e => e.Remarks).HasMaxLength(250);
            });

            modelBuilder.Entity<MasterCompaniesOl>(entity =>
            {
                entity.ToTable("MasterCompanies_Ols");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ExchangeId).HasColumnName("ExchangeID");

                entity.Property(e => e.ExchangeName).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Symbol).HasMaxLength(100);
            });

            modelBuilder.Entity<MasterCompanyList>(entity =>
            {
                entity.HasKey(e => e.Identifier);

                entity.ToTable("MasterCompanyList");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(70);

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.Eps)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("EPS");

                entity.Property(e => e.ExchangeId).HasColumnName("ExchangeID");

                entity.Property(e => e.FirstTradePrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IndexId).HasColumnName("IndexID");

                entity.Property(e => e.IndustryTypeId).HasColumnName("IndustryTypeID");

                entity.Property(e => e.Isactive).HasColumnName("ISActive");

                entity.Property(e => e.Isinumber)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ISINUMBER");

                entity.Property(e => e.MarketCapitalType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MarketCapitalValue).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ObserveEndDate).HasColumnType("datetime");

                entity.Property(e => e.ObserveStartDate).HasColumnType("datetime");

                entity.Property(e => e.RegisteredOn).HasColumnType("date");

                entity.Property(e => e.ScriptCode)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.SectorId).HasColumnName("SectorID");

                entity.Property(e => e.SeriesId).HasColumnName("SeriesID");

                entity.Property(e => e.Symbol)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SYMBOL");

                entity.Property(e => e.TotalAsset).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.UpdatedDate).HasColumnType("date");

                entity.HasOne(d => d.Series)
                    .WithMany(p => p.MasterCompanyLists)
                    .HasForeignKey(d => d.SeriesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MasterListedStock_MasterStockSeries");
            });

            modelBuilder.Entity<MasterExchangeList>(entity =>
            {
                entity.HasKey(e => e.Identifier);

                entity.ToTable("MasterExchangeList");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<MasterIndexList>(entity =>
            {
                entity.HasKey(e => e.Identifier);

                entity.ToTable("MasterIndexList");

                entity.Property(e => e.ExchangeId).HasColumnName("ExchangeID");

                entity.Property(e => e.IndexId).HasColumnName("IndexID");

                entity.Property(e => e.IndexValue).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterIndustryList>(entity =>
            {
                entity.HasKey(e => e.Identifier);

                entity.ToTable("MasterIndustryList");

                entity.Property(e => e.Desciption)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeId).HasColumnName("ExchangeID");

                entity.Property(e => e.IndustryId).HasColumnName("IndustryID");

                entity.Property(e => e.MarketCapital).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterSectorList>(entity =>
            {
                entity.HasKey(e => e.Identifier);

                entity.ToTable("MasterSectorList");

                entity.Property(e => e.Desciption)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeId).HasColumnName("ExchangeID");

                entity.Property(e => e.MarketCapital).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SectorId).HasColumnName("SectorID");
            });

            modelBuilder.Entity<MasterStockSeries>(entity =>
            {
                entity.HasKey(e => e.Identifier);

                entity.Property(e => e.SeriesName)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NiftyOptionMarketDeptOrderBook>(entity =>
            {
                entity.HasKey(e => e.Identifier);

                entity.ToTable("NiftyOptionMarketDeptOrderBook");

                entity.Property(e => e.AnnulaisedVolatility).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CarryBestBuy).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CarryBestSell).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CarryLastPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ChangeInOpenInterest).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ClientWisePositionLimit).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DailyVolitality).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ExpiryDate).HasColumnType("date");

                entity.Property(e => e.ImpliedVolitality).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IndexId).HasColumnName("IndexID");

                entity.Property(e => e.IndexName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.MarketLot).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.MarketWisePositionLimit).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.OpenInterest).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PchangeinOpenInterest)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("PChangeinOpenInterest");

                entity.Property(e => e.PremiumTurnOver).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PriceBestBuy).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PriceBestSell).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PriceLastPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SettlementPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.StampDate).HasColumnType("date");

                entity.Property(e => e.StrikePrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TradedVolume).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Value).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Vmap)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("VMAP");
            });

            modelBuilder.Entity<NiftyoptionDerivativesMetaDatum>(entity =>
            {
                entity.HasKey(e => e.Identifier);

                entity.ToTable("NIFTYOptionDerivativesMetaData");

                entity.Property(e => e.Change).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ClosePrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ExpiryDate).HasColumnType("date");

                entity.Property(e => e.HighPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IdentifierText)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IndexId).HasColumnName("IndexID");

                entity.Property(e => e.IndexName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.InstrumentType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.LowPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.NumberofContractTraded).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.OpenPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.OptionType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pchange)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("PChange");

                entity.Property(e => e.PrevClose).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.StampDate).HasColumnType("date");

                entity.Property(e => e.StrikePrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TotalTurnOver).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.UnderlyingValue).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.VolumeFreezeQuantity).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<NsebankNiftyCe>(entity =>
            {
                entity.HasKey(e => e.Identifier);

                entity.ToTable("NSEBankNiftyCE");

                entity.Property(e => e.AskPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.BidPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Change).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DateStamped).HasColumnType("date");

                entity.Property(e => e.ExpiryDate).HasColumnType("date");

                entity.Property(e => e.ImpliedVolatility).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IndexRate).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.LastPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.OpenInterest).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.OpenInterestChange).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PChange)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("pChange");

                entity.Property(e => e.PChangeinOpenInterest)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("pChangeinOpenINterest");

                entity.Property(e => e.StrikePrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.UnderlyingValue).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<NsebankNiftyPe>(entity =>
            {
                entity.HasKey(e => e.Identifier);

                entity.ToTable("NSEBankNiftyPE");

                entity.Property(e => e.AskPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.BidPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Change).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DateStamped).HasColumnType("date");

                entity.Property(e => e.ExpiryDate).HasColumnType("date");

                entity.Property(e => e.ImpliedVolatility).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IndexRate).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.LastPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.OpenInterest).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.OpenInterestChange).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PChange)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("pChange");

                entity.Property(e => e.PChangeinOpenInterest)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("pChangeinOpenINterest");

                entity.Property(e => e.StrikePrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.UnderlyingValue).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<NseniftyCe>(entity =>
            {
                entity.HasKey(e => e.Identifier);

                entity.ToTable("NSENiftyCE");

                entity.Property(e => e.AskPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.BidPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Change).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DateStamped).HasColumnType("date");

                entity.Property(e => e.ExpiryDate).HasColumnType("date");

                entity.Property(e => e.ImpliedVolatility).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IndexRate).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.LastPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.OpenInterest).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.OpenInterestChange).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PChange)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("pChange");

                entity.Property(e => e.PChangeinOpenInterest)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("pChangeinOpenINterest");

                entity.Property(e => e.StrikePrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.UnderlyingValue).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<NseniftyPe>(entity =>
            {
                entity.HasKey(e => e.Identifier);

                entity.ToTable("NSENiftyPE");

                entity.Property(e => e.AskPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.BidPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Change).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DateStamped).HasColumnType("date");

                entity.Property(e => e.ExpiryDate).HasColumnType("date");

                entity.Property(e => e.ImpliedVolatility).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IndexRate).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.LastPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.OpenInterest).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.OpenInterestChange).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PChange)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("pChange");

                entity.Property(e => e.PChangeinOpenInterest)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("pChangeinOpenINterest");

                entity.Property(e => e.StrikePrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.UnderlyingValue).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<OptionDerivativesMetaDatum>(entity =>
            {
                entity.HasKey(e => e.Identifier);

                entity.Property(e => e.Change).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ClosePrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ExpiryDate).HasColumnType("date");

                entity.Property(e => e.HighPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IdentifierText)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.InstrumentType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.LowPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.NumberofContractTraded).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.OpenPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.OptionType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pchange)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("PChange");

                entity.Property(e => e.PrevClose).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.StampDate).HasColumnType("date");

                entity.Property(e => e.StrikePrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TotalTurnOver).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.UnderlyingValue).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.VolumeFreezeQuantity).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<OptionMarketDeptOrderBook>(entity =>
            {
                entity.HasKey(e => e.Identifier);

                entity.ToTable("OptionMarketDeptOrderBook");

                entity.Property(e => e.AnnulaisedVolatility).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CarryBestBuy).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CarryBestSell).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CarryLastPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ChangeInOpenInterest).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ClientWisePositionLimit).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DailyVolitality).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ExpiryDate).HasColumnType("date");

                entity.Property(e => e.ImpliedVolitality).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.MarketLot).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.MarketWisePositionLimit).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.OpenInterest).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PchangeinOpenInterest)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("PChangeinOpenInterest");

                entity.Property(e => e.PremiumTurnOver).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PriceBestBuy).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PriceBestSell).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PriceLastPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SettlementPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.StampDate).HasColumnType("date");

                entity.Property(e => e.StrikePrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TradedVolume).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Value).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Vmap)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("VMAP");
            });

            modelBuilder.Entity<OptionType>(entity =>
            {
                entity.HasKey(e => e.Identifier);

                entity.ToTable("OptionType");

                entity.Property(e => e.Desciption)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OptionName)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PreOpenMarket>(entity =>
            {
                entity.HasKey(e => e.Identifier);

                entity.ToTable("PreOpenMarket");

                entity.Property(e => e.AtoBuyQty).HasColumnName("AtoBuyQTY");

                entity.Property(e => e.Atobuy)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ATOBuy");

                entity.Property(e => e.Atosell)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ATOSell");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyRefId).HasColumnName("CompanyRefID");

                entity.Property(e => e.DateStamp).HasColumnType("date");

                entity.Property(e => e.FinalPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Iep)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("IEP");
            });

            modelBuilder.Entity<PreOpenMarketList>(entity =>
            {
                entity.HasKey(e => e.Identifier);

                entity.ToTable("PreOpenMarketList");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyRefId).HasColumnName("CompanyRefID");

                entity.Property(e => e.DateStamp).HasColumnType("date");

                entity.Property(e => e.Iep).HasColumnName("IEP");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<SectorListHistory>(entity =>
            {
                entity.HasKey(e => e.Identifier);

                entity.ToTable("SectorListHistory");

                entity.Property(e => e.DateStamped).HasColumnType("date");

                entity.Property(e => e.MarketCapital).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SectorRefId).HasColumnName("SectorRefID");
            });

            modelBuilder.Entity<SecurityInfoMaintainWeek>(entity =>
            {
                entity.HasKey(e => e.Identifier);

                entity.ToTable("SecurityInfoMaintainWeek");

                entity.Property(e => e.BoardStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("boardStatus");

                entity.Property(e => e.ClassOfShare)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("classOfShare");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DateStamp).HasColumnType("date");

                entity.Property(e => e.Derivatives).HasColumnName("derivatives");

                entity.Property(e => e.FaceValue)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("faceValue");

                entity.Property(e => e.IssuedCap)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("issuedCap");

                entity.Property(e => e.SessionNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sessionNo");

                entity.Property(e => e.Slb)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("slb");

                entity.Property(e => e.Surveillance)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("surveillance");

                entity.Property(e => e.TradingSegment)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("tradingSegment");

                entity.Property(e => e.TradingStatus)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("tradingStatus");
            });

            modelBuilder.Entity<StockInfoMaintainWeek>(entity =>
            {
                entity.HasKey(e => e.Identifier);

                entity.ToTable("StockInfoMaintainWeek");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyRefId).HasColumnName("CompanyRefID");

                entity.Property(e => e.DateStamp).HasColumnType("date");

                entity.Property(e => e.IdentifierCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Industry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsCasec).HasColumnName("isCASec");

                entity.Property(e => e.IsDebtSec).HasColumnName("isDebtSec");

                entity.Property(e => e.IsDelisted).HasColumnName("isDelisted");

                entity.Property(e => e.IsEtfsec).HasColumnName("isETFSec");

                entity.Property(e => e.IsFnosec).HasColumnName("isFNOSec");

                entity.Property(e => e.IsSlbsec).HasColumnName("isSLBSec");

                entity.Property(e => e.IsSuspended).HasColumnName("isSuspended");

                entity.Property(e => e.IsTop10).HasColumnName("isTop10");

                entity.Property(e => e.Isin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("isin");

                entity.Property(e => e.Symbol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("symbol");
            });

            modelBuilder.Entity<StockMetaDataInfoMaintainWeek>(entity =>
            {
                entity.HasKey(e => e.Identifier);

                entity.ToTable("StockMetaDataInfoMaintainWeek");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyRefId).HasColumnName("CompanyRefID");

                entity.Property(e => e.DateStamp)
                    .HasColumnType("date")
                    .HasColumnName("DateSTamp");

                entity.Property(e => e.Industry)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Isinnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ISINNumber");

                entity.Property(e => e.ListingDate).HasColumnType("date");

                entity.Property(e => e.PdSectorInd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pdSectorInd");

                entity.Property(e => e.PdSectorPe)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("pdSectorPe");

                entity.Property(e => e.PdSymbolPe)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("pdSymbolPe");

                entity.Property(e => e.Series)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("series");

                entity.Property(e => e.Status)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.Symbol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("symbol");
            });

            modelBuilder.Entity<StockOptionsCe>(entity =>
            {
                entity.HasKey(e => e.Identifier);

                entity.ToTable("StockOptionsCE");

                entity.Property(e => e.AskPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.BidPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Change).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyRefId).HasColumnName("CompanyRefID");

                entity.Property(e => e.DateStamped).HasColumnType("date");

                entity.Property(e => e.ExpiryDate).HasColumnType("date");

                entity.Property(e => e.ImpliedVolatility).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.LastPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.OpenInterest).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.OpenInterestChange).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PChange)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("pChange");

                entity.Property(e => e.PChangeinOpenInterest)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("pChangeinOpenINterest");

                entity.Property(e => e.StockCurrentPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.StrikePrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.UnderlyingValue).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<StockOptionsPe>(entity =>
            {
                entity.HasKey(e => e.Identifier);

                entity.ToTable("StockOptionsPE");

                entity.Property(e => e.AskPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.BidPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Change).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyRefId).HasColumnName("CompanyRefID");

                entity.Property(e => e.DateStamped).HasColumnType("date");

                entity.Property(e => e.ExpiryDate).HasColumnType("date");

                entity.Property(e => e.ImpliedVolatility).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.LastPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.OpenInterest).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.OpenInterestChange).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PChange)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("pChange");

                entity.Property(e => e.PChangeinOpenInterest)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("pChangeinOpenINterest");

                entity.Property(e => e.StockCurrentPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.StrikePrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.UnderlyingValue).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<StockPriceInfo>(entity =>
            {
                entity.HasKey(e => e.Identifier);

                entity.ToTable("StockPriceInfo");

                entity.Property(e => e.BasePrice)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("basePrice");

                entity.Property(e => e.Change)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("change");

                entity.Property(e => e.ClosePrice)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("closePrice");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyRefId).HasColumnName("CompanyRefID");

                entity.Property(e => e.DateStamp).HasColumnType("date");

                entity.Property(e => e.IntraDayHigh)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("intraDayHigh");

                entity.Property(e => e.IntraDayLow)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("intraDayLow");

                entity.Property(e => e.LastPrice)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("lastPrice");

                entity.Property(e => e.LowerCp)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("lowerCP");

                entity.Property(e => e.OpenPrice)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("openPrice");

                entity.Property(e => e.PChange)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("pChange");

                entity.Property(e => e.PPriceBand)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pPriceBand");

                entity.Property(e => e.PreviousClose)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("previousClose");

                entity.Property(e => e.UpperCp)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("upperCP");

                entity.Property(e => e.Vwap)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("vwap");

                entity.Property(e => e.WeeklyHigh)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("weeklyHigh");

                entity.Property(e => e.WeeklyHighDate).HasColumnType("date");

                entity.Property(e => e.WeeklyLow).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.WeeklyLowDate).HasColumnType("date");
            });

            modelBuilder.Entity<TempCompanyList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TempCompanyList");

                entity.Property(e => e.DateOfListing)
                    .HasColumnType("date")
                    .HasColumnName("DATE_OF_LISTING");

                entity.Property(e => e.FaceValue).HasColumnName("FACE_VALUE");

                entity.Property(e => e.IsinNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ISIN_NUMBER");

                entity.Property(e => e.MarketLot).HasColumnName("MARKET_LOT");

                entity.Property(e => e.NameOfCompany)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NAME_OF_COMPANY");

                entity.Property(e => e.PaidUpValue).HasColumnName("PAID_UP_VALUE");

                entity.Property(e => e.Series)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("SERIES");

                entity.Property(e => e.Symbol)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("SYMBOL");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
