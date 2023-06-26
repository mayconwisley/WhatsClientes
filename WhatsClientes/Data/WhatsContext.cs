using Microsoft.EntityFrameworkCore;
using WhatsClientes.Model;

namespace WhatsClientes.Data;

public class WhatsContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
           optionsBuilder.UseSqlite("Data Source = banco.db");

    public DbSet<Contato> Contatos { get; set; }

}
