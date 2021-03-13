using Microsoft.AspNetCore.Mvc;
using PortfolioManager.Domain.Interface;
using PortfolioManager.Domain.Models;
using System.Threading.Tasks;

namespace PortfolioManager.Core.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class SectorController : ControllerBase
    {
        private readonly ISectorBusinessLogic _sectorBusinessLogic;
        public SectorController(ISectorBusinessLogic sectorBusinessLogic)
        {
            _sectorBusinessLogic = sectorBusinessLogic;
        }


        [HttpGet]
        public async Task<CompanySectorList> GetCompanySectors()
        {
            var companySectorList = await _sectorBusinessLogic.GetSectorList();

            return companySectorList;
        }
    }
}
