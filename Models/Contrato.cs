// Contrato.cs
using System;

namespace ServicoApi.Models
{
    public class Contrato
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public int ServicoId { get; set; }
        public Servico Servico { get; set; }
        public decimal PrecoCobrado { get; set; }
        public DateTime DataContratacao { get; set; }
    }
}
