using System;
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

        public void CriarContrato(int clienteId, int servicoId, decimal precoCobrado, DateTime dataContratacao)
        {
            var contrato = new Contrato
            {
                ClienteId = clienteId,
                ServicoId = servicoId,
                PrecoCobrado = precoCobrado,
                DataContratacao = dataContratacao
            };

            _context.Contratos.Add(contrato);
            _context.SaveChanges();
        }
    }
}