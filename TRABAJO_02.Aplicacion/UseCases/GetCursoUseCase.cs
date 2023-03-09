using TRABAJO_02.Aplicacion.Entidades;
using TRABAJO_02.Aplicacion.Interfaces;
namespace TRABAJO_02.Aplicacion.UseCases;

public class getCursoUseCase
{
    private readonly IRepositorioCurso _rCurso;
    public getCursoUseCase(IRepositorioCurso rCurso){
        _rCurso = rCurso;
    }
    public Curso Ejecutar(int id){
        return _rCurso.GetCursoID(id);
    }
}