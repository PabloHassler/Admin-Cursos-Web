using Microsoft.EntityFrameworkCore;
using TRABAJO_02.Aplicacion.Entidades;
namespace TRABAJO_02.Repositorios;
public class EscuelaContext : DbContext
{
    #nullable disable
    public DbSet<Estudiante> Estudiantes { get; set; }
    public DbSet<Curso> Cursos { get; set; }
    public DbSet<Inscripcion> Inscripciones { get; set; }
    #nullable restore
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("data source=./Database/Escuela.sqlite");
    }
}
