using Microsoft.EntityFrameworkCore;
using PortfolioManager.Data.Interface;
using PortfolioManager.Data.Models;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioManager.Data.Services
{
    public class SectorService : ISectorService
    {
        public readonly ApplicationDbContext _applicationDbContext;

        public SectorService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;

        }

        public async Task<string> GetSectorName(int sectorId)
        {
            var sectorName = await _applicationDbContext.MasterSectorLists
                .Where(s => s.Identifier == sectorId)
                .Select(x => x.Name)
                .FirstOrDefaultAsync();

            return sectorName;
        }
    }
}
