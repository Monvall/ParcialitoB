using Microsoft.EntityFrameworkCore;

namespace MiParcialitoA.Models
{
    public class InscripcionesDBContext : DbContext
    {
        public InscripcionesDBContext(DbContextOptions<InscripcionesDBContext> options) : base(options)
        {

        }

        public DbSet<Estudiantes> DEstudiantes { get; set; }

        public DbSet<Cursos> DCursos { get; set; }

        public DbSet<Inscripciones> DInscripciones { get; set; }
    }
}
