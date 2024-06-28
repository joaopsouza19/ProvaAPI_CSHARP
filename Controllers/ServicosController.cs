using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ServicoApi.Models;
using ServicoApi.Data;

namespace ServicoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class ServicosController : ControllerBase
    {
        private readonly ServicoContext _context;

        public ServicosController(ServicoContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult CriarServico([FromBody] Servico servico)
        {
            _context.Servicos.Add(servico);
            _context.SaveChanges();
            return Ok(servico);
        }

        [HttpGet("{id}")]
        public IActionResult ObterServico(int id)
        {
            var servico = _context.Servicos.Find(id);
            if (servico == null)
                return NotFound();

            return Ok(servico);
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarServico(int id, [FromBody] Servico servico)
        {
            var servicoExistente = _context.Servicos.Find(id);
            if (servicoExistente == null)
                return NotFound();

            servicoExistente.Nome = servico.Nome;
            servicoExistente.Preco = servico.Preco;
            servicoExistente.Status = servico.Status;

            _context.SaveChanges();
            return Ok(servicoExistente);
        }
    }
}