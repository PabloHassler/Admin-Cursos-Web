using TRABAJO_02.Aplicacion.Entidades;
using TRABAJO_02.Aplicacion.Interfaces;
namespace TRABAJO_02.Aplicacion.UseCases;
public class BajaEstudianteUseCase
{
    private readonly IRepositorioEstudiante _rEstudiante;
    private readonly IRepositorioInscripcion _rInscripcion;
    public BajaEstudianteUseCase(IRepositorioEstudiante rEstudiante, IRepositorioInscripcion rInscripcion){
        _rEstudiante = rEstudiante;
        _rInscripcion = rInscripcion;
    }
    public void Ejecutar(int dni){
        if(_rEstudiante.GetEstudiante(dni).Id!=-1){
            _rInscripcion.EliminarInscripciones(_rEstudiante.GetEstudiante(dni));
            _rEstudiante.EliminarEstudiante(dni);
        }
    }
}