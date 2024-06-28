// ContratoService.cs
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ServicoApi.Data;
using ServicoApi.Models;

namespace ServicoApi.Services
{
    public class ContratoService
    {
        private readonly ServicoContext _context;

        public ContratoService(ServicoContext context)
        {
            _context = context;
        }

        public List<Contrato> GetContratosCliente(int clienteId)
        {
            return _context.Contratos
                .Include(c => c.Servico)
                .Where(c => c.ClienteId == clienteId)
                .ToList();
        }
    }
}
