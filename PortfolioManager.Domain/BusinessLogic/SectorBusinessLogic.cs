using PortfolioManager.Data.Interface;
using PortfolioManager.Domain.Interface;
using PortfolioManager.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioManager.Domain.BusinessLogic
{
    public class SectorBusinessLogic : ISectorBusinessLogic
    {

        private readonly ICompanyBusinessLogic _companyBusinessLogic;
        private readonly ISectorService  _sectorService;

        public SectorBusinessLogic(ICompanyBusinessLogic companyBusinessLogic, ISectorService sectorService)
        {
            _companyBusinessLogic = companyBusinessLogic;
            _sectorService = sectorService;
        }

        public async Task<CompanySectorList> GetSectorList()
        {
            var companies = await _companyBusinessLogic.GetCompanies();

            List<string> sectorNames = new List<string>();
            List<int> companyTotalsPerSector = new List<int>();

            var groupedCompanies = companies
                .GroupBy(c => c.SectorId)
                .Select(x => new
                {
                    SectorId = x.Key,
                    TotalCompanies = x.Count()
                })
                .ToList();


            foreach (var group in groupedCompanies)
            {
                if(group.SectorId != null)
                {
                    var sectorName = await GetSectorName((int)group.SectorId);
                    sectorNames.Add(sectorName);
                }

                companyTotalsPerSector.Add(group.TotalCompanies);
            }

            var companySectorList = new CompanySectorList
            {
                SectorNames = sectorNames,
                CompanyTotalsPerSector = companyTotalsPerSector
            };

            return companySectorList;
        }

        private async Task<string> GetSectorName(int sectorId)
        {
            var sectorName = await _sectorService.GetSectorName(sectorId);
            return sectorName;
        }
    }
}
