using TRABAJO_02.Aplicacion.Entidades;
using TRABAJO_02.Aplicacion.Interfaces;
namespace TRABAJO_02.Aplicacion.UseCases;

public class ListarEstudiantesFinalUseCase{
    private IRepositorioEstudiante _rEstudiante;
    private IRepositorioCurso _rCurso;
    private IRepositorioInscripcion _rInscripcion;
    public ListarEstudiantesFinalUseCase(IRepositorioEstudiante rEstudiante, IRepositorioCurso rCurso, IRepositorioInscripcion rInscripcion){
        _rEstudiante = rEstudiante;
        _rCurso = rCurso;
        _rInscripcion = rInscripcion;
    }
    public List<Inscripcion> Ejecutar(){
        List<Inscripcion> lista = new List<Inscripcion>();
        List<Inscripcion> listaOrdenada = new List<Inscripcion>();
        List<Inscripcion> inscripciones = _rInscripcion.GetInscripciones();
        foreach(Inscripcion inscripcion in inscripciones){
            var fechaCursoFinalizacion=_rCurso.GetCursoID(inscripcion.Cursoid).FechaFinalizacion;
            if(fechaCursoFinalizacion!=null){
                if((DateTime.Now-fechaCursoFinalizacion.Value).Days>=0){
                    lista.Add(inscripcion);
                }
            }
        }
        listaOrdenada = lista.OrderBy(p => p.Cursoid).OrderBy(p => p.Estudianteid).ToList();
        return listaOrdenada;
    }
}