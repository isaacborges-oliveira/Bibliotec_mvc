using Bibliotec.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Bibliotec.Contexts
{
    public class Context : DbContext
    {
        public Context()
        {

        }
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)


        {
            if (!optionsBuilder.IsConfigured)
            {
   optionsBuilder.UseSqlServer(@"Data Source=NOTE27-S28\\SQLEXPRESS; 
   Initial Catalog = Bibliotec; 
    User Id=sa; Password=abc123; 
    Integrated Security=true;
     TrustServerCertificate = true");

            }
        }
       
        public DbSet<Categoria> Categoria {get; set;}
        public DbSet<Livro> Livro {get; set;}
        public DbSet<Usuario> Usuario {get; set;}
        public DbSet<LivroCategoria> LivroCategoria {get; set;}
        public DbSet<LivroReserva> LivroReserva {get; set;}
    }
}