// ServicoContext.cs
using Microsoft.EntityFrameworkCore;
using ServicoApi.Models;

namespace ServicoApi.Data
{
    public class ServicoContext : DbContext
    {
        public ServicoContext(DbContextOptions<ServicoContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<Contrato> Contratos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurações adicionais de modelos, se necessário
        }
    }
}
