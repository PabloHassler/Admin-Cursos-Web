using TRABAJO_02.Aplicacion.Entidades;
namespace TRABAJO_02.Aplicacion.Interfaces;
public interface IRepositorioCurso
{
    void AgregarCurso(Curso curso);
    List<Curso> GetCursos();
    Curso GetCurso(string Curso);
    Curso GetCursoID(int id);
    void ModificarCurso(Curso curso);
    void EliminarCurso(string Curso);
}