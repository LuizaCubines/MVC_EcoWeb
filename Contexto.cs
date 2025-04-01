

using Microsoft.EntityFrameworkCore;

namespace EcoWeb.Models{

    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto>options) : base(options)
        {
            
        }

        public DbSet<Usuario> Usuario {get; set;}


    }

    public class DbContexto
    {
    }
}