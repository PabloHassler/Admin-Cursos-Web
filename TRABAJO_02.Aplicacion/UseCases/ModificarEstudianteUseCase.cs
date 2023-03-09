using TRABAJO_02.Aplicacion.Entidades;
using TRABAJO_02.Aplicacion.Interfaces;
namespace TRABAJO_02.Aplicacion.UseCases;

public class ModificarEstudianteUseCase
{
    private readonly IRepositorioEstudiante _rEstudiante;
    public ModificarEstudianteUseCase(IRepositorioEstudiante rEstudiante){
        _rEstudiante = rEstudiante;
    }
    public void Ejecutar(Estudiante estudiante){
        if(_rEstudiante.GetEstudiante(estudiante.Dni).Id==-1 || _rEstudiante.GetEstudiante(estudiante.Dni).Id==estudiante.Id){
            _rEstudiante.ModificarEstudiante(estudiante);
        }
    }
}