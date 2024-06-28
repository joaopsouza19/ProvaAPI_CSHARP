// ContratoController.cs
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ServicoApi.Services;

namespace ServicoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize] // Para exigir autenticação JWT em todos os métodos deste controller
    public class ContratoController : ControllerBase
    {
        private readonly ContratoService _contratoService;

        public ContratoController(ContratoService contratoService)
        {
            _contratoService = contratoService;
        }

        [HttpGet("clientes/{clienteId}/servicos")]
        public IActionResult GetServicosContratados(int clienteId)
        {
            var contratos = _contratoService.GetContratosCliente(clienteId);
            return Ok(contratos);
        }
    }
}
