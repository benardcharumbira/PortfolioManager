using Microsoft.EntityFrameworkCore;
using PortfolioManager.Data.Interface;
using PortfolioManager.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PortfolioManager.Data.Services
{
    public class CompanyService : ICompanyService
    {
        public readonly ApplicationDbContext _applicationDbContext;
        public CompanyService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public async Task<List<MasterCompanyList>> GetCompanies()
        {
            var companies = await _applicationDbContext.MasterCompanyLists.ToListAsync();
            return companies;
        }
    }
}
