using TRABAJO_02.Aplicacion.Entidades;
using TRABAJO_02.Aplicacion.Interfaces;
namespace TRABAJO_02.Repositorios;

public class RepositorioInscripcion : IRepositorioInscripcion
{
    public void AgregarInscripcion(Inscripcion inscripcion){
        using (var db = new EscuelaContext()){
            var ExiteInscripcion = db.Inscripciones.Where(i => i.Estudianteid == inscripcion.Estudianteid && i.Cursoid ==inscripcion.Cursoid).FirstOrDefault();
            if(ExiteInscripcion == null){
                db.Inscripciones.Add(inscripcion);
            }
            db.SaveChanges();
        }
    }
    public List<Inscripcion> GetInscripciones(){
        List<Inscripcion> inscripciones = new List<Inscripcion>();
        using (var db = new EscuelaContext()){
            foreach (Inscripcion a in db.Inscripciones){
                inscripciones.Add(a);
            }
            db.SaveChanges();
        }
        return inscripciones;
    }
    public Inscripcion GetInscripcion(int estudianteID, int cursoID){
        Inscripcion inscripcion = new Inscripcion();
        inscripcion.Id=-1;
        using (var db = new EscuelaContext()){
            var getInscripcion = db.Inscripciones.Where(i => i.Estudianteid == estudianteID && i.Cursoid == cursoID).FirstOrDefault();
            if(getInscripcion != null){
                inscripcion = getInscripcion;
            }
        }
        return inscripcion;
    }
    public Inscripcion GetInscripcionID(int id){
        Inscripcion inscripcion = new Inscripcion();
        inscripcion.Id = -1;
        using (var db = new EscuelaContext()){
            var getInscripcion = db.Inscripciones.Where(i => i.Id == id).FirstOrDefault();
            if(getInscripcion != null){
                inscripcion = getInscripcion;
            }
        }
        return inscripcion;
    }
    public void ModificarInscripcion(Inscripcion inscripcion){
        using (var db = new EscuelaContext()){
            var ModificarInscripcion=db.Inscripciones.Where(c => c.Id == inscripcion.Id).FirstOrDefault();
            if(ModificarInscripcion != null){
                db.Inscripciones.Remove(ModificarInscripcion);
                db.Inscripciones.Update(inscripcion);
            }
            db.SaveChanges();
        }
    }
    public void EliminarInscripcion(Inscripcion inscripcion){
        using (var db = new EscuelaContext()){
            var BorrarInscripcion= db.Inscripciones.Where(c => c.Estudianteid == inscripcion.Estudianteid && c.Cursoid == inscripcion.Cursoid).FirstOrDefault();
            if(BorrarInscripcion != null){
                db.Inscripciones.Remove(BorrarInscripcion);
            }
            db.SaveChanges();
        }
    }
    public void EliminarInscripciones(Estudiante estudiante){
        using (var db = new EscuelaContext()){
            var BorrarInscripciones= db.Inscripciones.Where(c => c.Estudianteid == estudiante.Id).ToList();
            if(BorrarInscripciones != null){
                db.Inscripciones.RemoveRange(BorrarInscripciones);
            }
            db.SaveChanges();
        }
    }
    public void EliminarInscripciones(Curso curso){
        using (var db = new EscuelaContext()){
            var BorrarInscripciones= db.Inscripciones.Where(c => c.Cursoid == curso.Id).ToList();
            if(BorrarInscripciones != null){
                db.Inscripciones.RemoveRange(BorrarInscripciones);
            }
            db.SaveChanges();
        }
    }
}