using Microsoft.AspNetCore.Mvc;
using PortfolioManager.Data.Models;
using PortfolioManager.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PortfolioManager.Core.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyBusinessLogic _companyBusinessLogic;
        public CompanyController(ICompanyBusinessLogic companyBusinessLogic)
        {
            _companyBusinessLogic = companyBusinessLogic;
        }

        [HttpGet]
        public async Task<List<MasterCompanyList>> GetCompanies()
        {
            var companies = await _companyBusinessLogic.GetCompanies();
            return companies;
        }
    }
}
