namespace TRABAJO_02.Aplicacion.Entidades;
public class Inscripcion
{
    public int Id { get; set; }
    public int Estudianteid { get; set; }
    public int Cursoid { get; set; }
    public DateTime FechaInscripcion { get; set; }=DateTime.Now;
}