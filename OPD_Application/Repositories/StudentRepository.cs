using PDBEF;
using Microsoft.EntityFrameworkCore;
using OPD_Application.Contexts;
using OPD_Application.Exceptions;

namespace OPD_Application.Repositories
{
    public class StudentRepository : IRepository<Student>
    {
        private StudentContext db;

        public StudentRepository()
        {
            this.db = new StudentContext("Server=(localdb)\\mssqllocaldb;Database=helloappdb;Trusted_Connection=True;");
        }

        public Student GetModel(int id)
        {
            return db.Students.Find(id);
        }

        public void Create(Student student)
        {
            db.Students.Add(student);
            Save();
        }

        public void Update(Student student)
        {
            if (!db.Students.Select(x => x.Id).ToArray().Contains(student.Id))
            {
                throw new StudentNotFoundException("Student not found");
            }

            db.Students.Update(student);
            Save();
        }

        public void Delete(int id)
        {
            Student student = db.Students.Find(id);
            if (student != null)
                db.Students.Remove(student);

            Save();
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public IEnumerable<Student> GetModels()
        {
            return db.Students;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
