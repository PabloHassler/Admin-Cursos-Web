using TRABAJO_02.Aplicacion.Entidades;
using TRABAJO_02.Aplicacion.Interfaces;
namespace TRABAJO_02.Aplicacion.UseCases;

public class AltaCursoUseCase
{
    private readonly IRepositorioCurso _rCurso;
    public AltaCursoUseCase(IRepositorioCurso rCurso){
        _rCurso = rCurso;
    }
    public void Ejecutar(Curso curso){
        _rCurso.AgregarCurso(curso);
    }
}
