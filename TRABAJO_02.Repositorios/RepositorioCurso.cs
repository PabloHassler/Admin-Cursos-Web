using TRABAJO_02.Aplicacion.Entidades;
using TRABAJO_02.Aplicacion.Interfaces;
namespace TRABAJO_02.Repositorios;

public class RepositorioCurso : IRepositorioCurso
{
    public void AgregarCurso(Curso curso){
        using (var db = new EscuelaContext()){
            db.Database.EnsureCreated();
            var ExisteCurso=db.Cursos.Where(c => c.Titulo == curso.Titulo).FirstOrDefault();
            if(ExisteCurso==null){
                db.Cursos.Add(curso);
            }
            db.SaveChanges();
        }
    }
    public List<Curso> GetCursos(){
        List<Curso> cursos = new List<Curso>();
        using (var db = new EscuelaContext()){
            foreach (Curso a in db.Cursos){
                cursos.Add(a);
            }
            db.SaveChanges();
        }
        return cursos;
    }
    public Curso GetCurso(string Curso){
        Curso curso = new Curso();
        curso.Id=-1;
        using (var db = new EscuelaContext()){
            var getCurso=db.Cursos.Where(c => c.Titulo == Curso).FirstOrDefault();
            if(getCurso!=null){
                curso = getCurso;
            }
        }
        return curso;
    }
    public Curso GetCursoID(int id){
        Curso curso = new Curso();
        curso.Id=-1;
        using (var db = new EscuelaContext()){
            var getCurso=db.Cursos.Where(c => c.Id == id).FirstOrDefault();
            if(getCurso!=null){
                curso = getCurso;
            }
        }
        return curso;
    }
    public void ModificarCurso(Curso curso){
         using (var db = new EscuelaContext()){
            var ModificarCurso=db.Cursos.Where(c => c.Id == curso.Id).FirstOrDefault();
            if(ModificarCurso != null){
                db.Cursos.Remove(ModificarCurso);
                db.Cursos.Update(curso);
            }
            db.SaveChanges();
         }
    }
    public void EliminarCurso(string curso){
        using (var db = new EscuelaContext()){
            var BorrarCurso= db.Cursos.Where(c => c.Titulo == curso).FirstOrDefault();
            if(BorrarCurso != null){
                db.Cursos.Remove(BorrarCurso);
            }
            db.SaveChanges();
        }
    }
}