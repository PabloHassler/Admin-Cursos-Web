using TRABAJO_02.Aplicacion.Entidades;
using TRABAJO_02.Aplicacion.Interfaces;
namespace TRABAJO_02.Aplicacion.UseCases;
public class ListaDeEstudiantesUseCase
{
    private readonly IRepositorioEstudiante _rEstudiante;
    public ListaDeEstudiantesUseCase(IRepositorioEstudiante rEstudiante){
        _rEstudiante = rEstudiante;
    }
    public List<Estudiante> Ejecutar(){
        List<Estudiante> listaOrdenada = new List<Estudiante>();
        listaOrdenada=_rEstudiante.GetEstudiantes().OrderBy(x=>x.Apellido).OrderBy(x=>x.Nombre).OrderBy(x=>x.Dni).OrderBy(x=>x.Id).ToList();
        return listaOrdenada;
    }
}