using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ServicoApi.Services;
using System;

namespace ServicoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class ContratosController : ControllerBase
    {
        private readonly ContratoService _contratoService;

        public ContratosController(ContratoService contratoService)
        {
            _contratoService = contratoService;
        }

        [HttpPost]
        public IActionResult RegistrarContrato([FromBody] ContratoRequest contratoRequest)
        {
            try
            {
                _contratoService.CriarContrato(contratoRequest.ClienteId, contratoRequest.ServicoId,
                                               contratoRequest.PrecoCobrado, contratoRequest.DataContratacao);
                return Ok("Contrato registrado com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao registrar contrato: {ex.Message}");
            }
        }
    }

    public class ContratoRequest
    {
        public int ClienteId { get; set; }
        public int ServicoId { get; set; }
        public decimal PrecoCobrado { get; set; }
        public DateTime DataContratacao { get; set; }
    }
}