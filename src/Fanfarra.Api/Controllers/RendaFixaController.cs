using System.Threading.Tasks;
using Fanfarra.Domain.Connectors;
using Microsoft.AspNetCore.Mvc;

namespace Fanfarra.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RendaFixaController : Controller
    {
        private readonly IRendaFixaConnector _rendaFixaConnector;

        public RendaFixaController(IRendaFixaConnector rendaFixaConnector)
        {
            _rendaFixaConnector = rendaFixaConnector;
        }

        [HttpGet]
        public async Task<IActionResult> GetCustody()
        {
            var teste = _rendaFixaConnector.ObterCustodia();
            return Ok(teste);
        }
    }
}
