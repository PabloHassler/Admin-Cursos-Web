using TRABAJO_02.Aplicacion.Entidades;
using TRABAJO_02.Aplicacion.Interfaces;
namespace TRABAJO_02.Aplicacion.UseCases;

public class ModificarInscripcionUseCase
{
    private readonly IRepositorioInscripcion _rInscripcion;
    public ModificarInscripcionUseCase(IRepositorioInscripcion rInscripcion){
        _rInscripcion = rInscripcion;
    }
    public void Ejecutar(Inscripcion inscripcion){
        if(_rInscripcion.GetInscripcion(inscripcion.Estudianteid,inscripcion.Cursoid).Id==-1 || _rInscripcion.GetInscripcion(inscripcion.Estudianteid,inscripcion.Cursoid).Id==inscripcion.Id){
            _rInscripcion.ModificarInscripcion(inscripcion);
        }
    }    
}