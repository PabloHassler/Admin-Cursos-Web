using TRABAJO_02.Aplicacion.Entidades;
using TRABAJO_02.Aplicacion.Interfaces;
namespace TRABAJO_02.Aplicacion.UseCases;
public class BajaInscripcionUseCase
{
    private readonly IRepositorioInscripcion _rInscripcion;
    private readonly IRepositorioEstudiante _rEstudiante;
    private readonly IRepositorioCurso _rCurso;
    public BajaInscripcionUseCase(IRepositorioInscripcion rInscripcion, IRepositorioEstudiante rEstudiante, IRepositorioCurso rCurso){
        _rInscripcion = rInscripcion;
        _rEstudiante = rEstudiante;
        _rCurso = rCurso;
    }
    public void Ejecutar(int Dni, string Titulo){
        if(_rEstudiante.GetEstudiante(Dni).Id!=-1){
            if(_rCurso.GetCurso(Titulo).Id!=-1){
                Inscripcion inscripcion = new Inscripcion();
                inscripcion.Estudianteid=_rEstudiante.GetEstudiante(Dni).Id;
                inscripcion.Cursoid=_rCurso.GetCurso(Titulo).Id;
                inscripcion.FechaInscripcion=DateTime.Now;
                _rInscripcion.EliminarInscripcion(inscripcion);
            }
        }
    }

}