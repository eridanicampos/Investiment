using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using Services.Models;

namespace InvestimentB3.Api.Controllers
{
    [ApiController]
    [Route("CDB")]

    public class CDBController : ControllerBase
    {
        private readonly ICDBService _CDBService;

        private readonly ILogger<CDBController> _logger;

        public CDBController(ILogger<CDBController> logger, ICDBService CDBService)
        {
            _logger = logger;
            _CDBService = CDBService;
        }

        [HttpPost("calcularInvestimento")]
        public async Task<IActionResult> CalcularInvestimento([FromBody] InvestimentCDBModel investimentCDBModel)
        {
            _logger.LogDebug("Inicio do método CalcularInvestimento ");
            return Ok(await _CDBService.CalcularCDBInvestimento(investimentCDBModel));
        }

    }
}
