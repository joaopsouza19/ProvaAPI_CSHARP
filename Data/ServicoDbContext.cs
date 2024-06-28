using Microsoft.EntityFrameworkCore;
using ServicoApi.Models;

public class ServicoDbContext : DbContext
{
    public ServicoDbContext(DbContextOptions<ServicoDbContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<Servico> Servicos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasNoKey();
        modelBuilder.Entity<Servico>().HasNoKey();
    }
}
