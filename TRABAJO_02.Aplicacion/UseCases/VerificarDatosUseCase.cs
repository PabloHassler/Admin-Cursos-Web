using TRABAJO_02.Aplicacion.Entidades;
using TRABAJO_02.Aplicacion.Interfaces;
namespace TRABAJO_02.Aplicacion.UseCases;

public class VerificarDatosUseCase{
    private readonly IRepositorioEstudiante _rEstudiante;
    private readonly IRepositorioCurso _rCurso;
    private readonly IRepositorioInscripcion _rInscripcion;
    public VerificarDatosUseCase(IRepositorioEstudiante rEstudiante, IRepositorioCurso rCurso, IRepositorioInscripcion rInscripcion){
        _rEstudiante = rEstudiante;
        _rCurso = rCurso;
        _rInscripcion = rInscripcion;
    }
    public bool Ejecutar(Estudiante estudiante){
        bool resultado = true;
        if(estudiante.Dni==null || estudiante.Dni<1){
            resultado = false;
        }
        if(estudiante.Nombre==""){
            resultado = false;
        }
        if(estudiante.Apellido==""){
            resultado = false;
        }
        if(estudiante.Email==""){
            resultado = false;
        }
        return resultado;
    }
    public bool Ejecutar(Curso curso){
        bool resultado = true;
        if(curso.Titulo==""){
            resultado = false;
        }
        if(curso.Descripcion==""){
            resultado = false;
        }
        if(curso.FechaInicio==null){
            resultado = false;
        }
        if(curso.FechaFinalizacion==null){
            resultado = false;
        }
        return resultado;
    }
}