using PortfolioManager.Domain.Models;
using System.Threading.Tasks;

namespace PortfolioManager.Domain.Interface
{
    public interface ISectorBusinessLogic
    {
        Task<CompanySectorList> GetSectorList();
    }
}
