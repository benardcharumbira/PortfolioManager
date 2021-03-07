using PortfolioManager.Data.Interface;
using PortfolioManager.Data.Models;
using PortfolioManager.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PortfolioManager.Domain.BusinessLogic
{
    public class CompanyBusinessLogic : ICompanyBusinessLogic
    {
        private readonly ICompanyService _companyService;
        public CompanyBusinessLogic(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        public async Task<List<MasterCompanyList>> GetCompanies()
        {
            var companies = await _companyService.GetCompanies();
            return companies;
        }
    }
}
