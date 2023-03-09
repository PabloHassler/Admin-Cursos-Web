using TRABAJO_02.Aplicacion.Entidades;
using TRABAJO_02.Aplicacion.Interfaces;
namespace TRABAJO_02.Aplicacion.UseCases;

public class getInscripcionUseCase{
    private readonly IRepositorioInscripcion _rInscripcion;
    public getInscripcionUseCase(IRepositorioInscripcion rInscripcion){
        _rInscripcion = rInscripcion;
    }
    public Inscripcion Ejecutar(int id){
        return _rInscripcion.GetInscripcionID(id);
    }
}