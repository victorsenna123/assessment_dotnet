using Microsoft.EntityFrameworkCore;
using EX_7.Models;

namespace EX_7.Data
{
    public class LivroContext : DbContext
    {
        public LivroContext(DbContextOptions<LivroContext> options) : base(options) { }

        public DbSet<Livro> Livros { get; set; }
    }
}
