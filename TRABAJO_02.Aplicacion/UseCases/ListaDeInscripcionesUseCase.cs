using TRABAJO_02.Aplicacion.Entidades;
using TRABAJO_02.Aplicacion.Interfaces;
namespace TRABAJO_02.Aplicacion.UseCases;

public class ListaDeInscripcionesUseCase
{
    private readonly IRepositorioInscripcion _rInscripcion;
    public ListaDeInscripcionesUseCase(IRepositorioInscripcion rInscripcion){
        _rInscripcion = rInscripcion;
    }
    public List<Inscripcion> Ejecutar(){
        List<Inscripcion> listaOrdenada = new List<Inscripcion>();
        listaOrdenada=_rInscripcion.GetInscripciones().OrderBy(x=>x.Cursoid).OrderBy(x=>x.Estudianteid).OrderBy(x=>x.Id).ToList();
        return listaOrdenada;
    }
}