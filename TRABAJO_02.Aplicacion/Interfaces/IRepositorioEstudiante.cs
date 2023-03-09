using TRABAJO_02.Aplicacion.Entidades;
namespace TRABAJO_02.Aplicacion.Interfaces;
public interface IRepositorioEstudiante
{
    void AgregarEstudiante(Estudiante estudiante);
    List<Estudiante> GetEstudiantes();
    Estudiante GetEstudiante(int? dni);
    Estudiante GetEstudianteID(int id);
    void ModificarEstudiante(Estudiante estudiante);
    void EliminarEstudiante(int? dni);
}