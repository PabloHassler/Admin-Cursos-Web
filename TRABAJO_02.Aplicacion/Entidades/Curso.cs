namespace TRABAJO_02.Aplicacion.Entidades;

public class Curso
{
    public int Id { get; set; }
    public string Titulo { get; set; }="";
    public string Descripcion { get; set; }="";
    public DateTime? FechaInicio { get; set; }
    public DateTime? FechaFinalizacion { get; set; }

}