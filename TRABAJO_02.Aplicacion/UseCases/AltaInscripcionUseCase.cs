using TRABAJO_02.Aplicacion.Entidades;
using TRABAJO_02.Aplicacion.Interfaces;
namespace TRABAJO_02.Aplicacion.UseCases;

public class AltaInscripcionUseCase
{
    private readonly IRepositorioInscripcion _rInscripcion;
    private readonly IRepositorioEstudiante _rEstudiante;
    private readonly IRepositorioCurso _rCurso;
    public AltaInscripcionUseCase(IRepositorioInscripcion rInscripcion, IRepositorioEstudiante rEstudiante, IRepositorioCurso rCurso){
        _rInscripcion = rInscripcion;
        _rEstudiante = rEstudiante;
        _rCurso = rCurso;
    }
    public void Ejecutar(Estudiante estudiante, Curso curso, DateTime fecha){
        if(_rEstudiante.GetEstudiante(estudiante.Dni).Id!=-1){
            if(_rCurso.GetCurso(curso.Titulo).Id!=-1){
                Inscripcion inscripcion = new Inscripcion();
                inscripcion.Estudianteid=estudiante.Id;
                inscripcion.Cursoid=curso.Id;
                inscripcion.FechaInscripcion=fecha;
                _rInscripcion.AgregarInscripcion(inscripcion);
            }
        }
    }
}