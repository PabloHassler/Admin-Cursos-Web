using TRABAJO_02.Aplicacion.Entidades;
using TRABAJO_02.Aplicacion.Interfaces;
namespace TRABAJO_02.Aplicacion.UseCases;

public class ListarCursosPorEstudianteUseCase{
    private IRepositorioEstudiante _rEstudiante;
    private IRepositorioInscripcion _rInscripcion;
    public ListarCursosPorEstudianteUseCase(IRepositorioEstudiante rEstudiante, IRepositorioInscripcion rInscripcion){
        _rEstudiante = rEstudiante;
        _rInscripcion = rInscripcion;
    }
    public List<Inscripcion> Ejecutar(Estudiante estudiante){
        List<Inscripcion> lista = new List<Inscripcion>();
        List<Inscripcion> listaOrdenada = new List<Inscripcion>();
        List<Inscripcion> inscripciones = _rInscripcion.GetInscripciones();
        if(_rEstudiante.GetEstudiante(estudiante.Dni).Id!=-1){    
            foreach(Inscripcion inscripcion in inscripciones){
                if(inscripcion.Estudianteid==estudiante.Id){
                    lista.Add(inscripcion);
                }
            }
            listaOrdenada = lista.OrderBy(p => p.Cursoid).ToList();
        }
    return listaOrdenada;
    }
}