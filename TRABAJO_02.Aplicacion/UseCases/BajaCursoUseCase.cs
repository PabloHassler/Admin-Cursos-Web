using TRABAJO_02.Aplicacion.Entidades;
using TRABAJO_02.Aplicacion.Interfaces;
namespace TRABAJO_02.Aplicacion.UseCases;

public class BajaCursoUseCase
{
    private readonly IRepositorioCurso _rCurso;
    private readonly IRepositorioInscripcion _rInscripcion;
    public BajaCursoUseCase(IRepositorioCurso rCurso, IRepositorioInscripcion rInscripcion){
        _rCurso = rCurso;
        _rInscripcion = rInscripcion;
    }
    public void Ejecutar(string titulo){
        if(_rCurso.GetCurso(titulo).Id!=-1){
            _rInscripcion.EliminarInscripciones(_rCurso.GetCurso(titulo));
            _rCurso.EliminarCurso(titulo);
        }
    }
}