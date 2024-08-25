using Microsoft.EntityFrameworkCore;

namespace PraticaAnnotation.Models
{
    
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Curso> Cursos { get; set; } // criacao de dependencia do modelo curso

        
    }
}
