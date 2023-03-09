using TRABAJO_02.Aplicacion.Entidades;
using TRABAJO_02.Aplicacion.Interfaces;
namespace TRABAJO_02.Aplicacion.UseCases;

public class getEstudianteUseCase
{
    private readonly IRepositorioEstudiante _rEstudiante;
    public getEstudianteUseCase(IRepositorioEstudiante rEstudiante){
        _rEstudiante = rEstudiante;
    }
    public Estudiante Ejecutar(int id){
        return _rEstudiante.GetEstudianteID(id);
    }
}
