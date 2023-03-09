using TRABAJO_02.Aplicacion.Entidades;
using TRABAJO_02.Aplicacion.Interfaces;
namespace TRABAJO_02.Aplicacion.UseCases;

public class ListarEstudiantesPorCursoUseCase
{
    private IRepositorioCurso _rCurso;
    private IRepositorioInscripcion _rInscripcion;
    public ListarEstudiantesPorCursoUseCase(IRepositorioCurso rCurso, IRepositorioInscripcion rInscripcion){
        _rCurso = rCurso;
        _rInscripcion = rInscripcion;
    }
    public List<Inscripcion> Ejecutar(Curso curso){
        List<Inscripcion> lista = new List<Inscripcion>();
        List<Inscripcion> listaOrdenada = new List<Inscripcion>();
        List<Inscripcion> inscripciones = _rInscripcion.GetInscripciones();
        if(_rCurso.GetCurso(curso.Titulo).Id!=-1){    
            foreach(Inscripcion inscripcion in inscripciones){
                if(inscripcion.Cursoid==curso.Id){
                    lista.Add(inscripcion);
                }
            }
            listaOrdenada = lista.OrderBy(p => p.Estudianteid).ToList();
        }
        return listaOrdenada;
    }
}