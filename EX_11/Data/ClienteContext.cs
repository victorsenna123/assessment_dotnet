using Microsoft.EntityFrameworkCore;
using EX_11.Models;

namespace GerenciamentoClientes.Data
{
    public class ClienteContext : DbContext
    {
        public ClienteContext(DbContextOptions<ClienteContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
