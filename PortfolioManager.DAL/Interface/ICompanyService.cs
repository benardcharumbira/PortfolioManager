using PortfolioManager.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PortfolioManager.Data.Interface
{
    public interface ICompanyService
    {
        /// <summary>
        /// Get list of all the companies
        /// </summary>
        /// <returns></returns>
        Task<List<MasterCompanyList>> GetCompanies();
    }
}
