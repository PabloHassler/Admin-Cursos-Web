using TRABAJO_02.Aplicacion.Entidades;
using TRABAJO_02.Aplicacion.Interfaces;
namespace TRABAJO_02.Aplicacion.UseCases;
public class ListaDeCursosUseCase
{
    private readonly IRepositorioCurso _rCurso;
    public ListaDeCursosUseCase(IRepositorioCurso rCurso){
        _rCurso = rCurso;
    }
    public List<Curso> Ejecutar(){
        List<Curso> listaOrdenada = new List<Curso>();
        listaOrdenada=_rCurso.GetCursos().OrderBy(x=>x.Titulo).OrderBy(x=>x.Id).ToList();
        return listaOrdenada;
    }
}