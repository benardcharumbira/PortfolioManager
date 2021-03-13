using System.Threading.Tasks;

namespace PortfolioManager.Data.Interface
{
    public interface ISectorService
    {
        Task<string> GetSectorName(int sectorId);
    }
}
