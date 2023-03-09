using TRABAJO_02.Aplicacion.Entidades;
using TRABAJO_02.Aplicacion.Interfaces;
namespace TRABAJO_02.Repositorios;

public class RepositorioEstudiante : IRepositorioEstudiante
{
    public void AgregarEstudiante(Estudiante estudiante){
        if(estudiante.Dni!=null){
            using (var db = new EscuelaContext()){
                var ExisteEstudiante=db.Estudiantes.Where(c => c.Dni == estudiante.Dni).FirstOrDefault();
                if(ExisteEstudiante==null){
                    db.Estudiantes.Add(estudiante);
                    db.SaveChanges();
                }
            }
        }
    }
    public List<Estudiante> GetEstudiantes(){
        List<Estudiante> estudiantes = new List<Estudiante>();
        using (var db = new EscuelaContext()){
            db.Database.EnsureCreated();
            foreach (Estudiante a in db.Estudiantes){
                estudiantes.Add(a);
            }
            db.SaveChanges();
        }
        return estudiantes;
    }
    public Estudiante GetEstudiante(int? dni){
        Estudiante estudiante = new Estudiante();
        estudiante.Id=-1;
        using (var db = new EscuelaContext()){
            var getEstudiante = db.Estudiantes.Where(c => c.Dni == dni).FirstOrDefault();
            if(getEstudiante!=null){
                estudiante = getEstudiante;
            }
        }
        return estudiante;
    }
    public Estudiante GetEstudianteID(int id){
        Estudiante estudiante = new Estudiante();
        estudiante.Id=-1;
        using (var db = new EscuelaContext()){
            var getEstudiante = db.Estudiantes.Where(c => c.Id == id).FirstOrDefault();
            if(getEstudiante!=null){
                estudiante = getEstudiante;
            }
        }
        return estudiante;
    }
    public void ModificarEstudiante(Estudiante estudiante){
        using (var db = new EscuelaContext()){
            var ModificarEstudiante=db.Estudiantes.Where(c => c.Id == estudiante.Id).FirstOrDefault();
            if(ModificarEstudiante != null){
                db.Estudiantes.Remove(ModificarEstudiante);
                db.Estudiantes.Update(estudiante);
            }
            db.SaveChanges();
        }
    }
    public void EliminarEstudiante(int? dni){
        using (var db = new EscuelaContext()){
            var BorrarEstudiante= db.Estudiantes.Where(c => c.Dni == dni).FirstOrDefault();
            if(BorrarEstudiante != null){
                db.Estudiantes.Remove(BorrarEstudiante);
            }
            db.SaveChanges();
        }
    }
}