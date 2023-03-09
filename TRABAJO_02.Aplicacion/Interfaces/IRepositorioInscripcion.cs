using TRABAJO_02.Aplicacion.Entidades;
namespace TRABAJO_02.Aplicacion.Interfaces;
public interface IRepositorioInscripcion
{
    void AgregarInscripcion(Inscripcion inscripcion);
    List<Inscripcion> GetInscripciones();
    Inscripcion GetInscripcion(int estudianteID, int cursoID);
    Inscripcion GetInscripcionID(int id);
    void ModificarInscripcion(Inscripcion inscripcion);
    void EliminarInscripcion(Inscripcion inscripcion);
    void EliminarInscripciones(Estudiante estudiante);
    void EliminarInscripciones(Curso curso);
}