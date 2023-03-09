using TRABAJO_02.Aplicacion.Entidades;
using TRABAJO_02.Aplicacion.Interfaces;
namespace TRABAJO_02.Aplicacion.UseCases;

public class ModificarCursoUseCase
{
    private readonly IRepositorioCurso _rCurso;
    public ModificarCursoUseCase(IRepositorioCurso rCurso){
        _rCurso = rCurso;
    }
    public void Ejecutar(Curso curso){
        if(_rCurso.GetCurso(curso.Titulo).Id==-1 || _rCurso.GetCurso(curso.Titulo).Id==curso.Id){
            _rCurso.ModificarCurso(curso);
        }
    }
}