using PDBEF;
using Microsoft.EntityFrameworkCore;
using OPD_Application.Contexts;
using OPD_Application.Exceptions;

namespace OPD_Application.Repositories
{
    public class LectureRepository : IRepository<Lecture>
    {
        private LectureContext db;

        public LectureRepository()
        {
            this.db = new LectureContext("Server=(localdb)\\mssqllocaldb;Database=helloappdb;Trusted_Connection=True;");
        }

        public Lecture GetModel(int id)
        {
            return db.Lectures.Find(id);
        }

        public void Create(Lecture lecture)
        {
            db.Lectures.Add(lecture);
            Save();
        }

        public void Update(Lecture lecture)
        {
            if (!db.Lectures.Select(x => x.Id).ToArray().Contains(lecture.Id))
            {
                throw new LectureNotFoundException("Lecture not found");
            }

            db.Lectures.Update(lecture);
            Save();
        }

        public void Delete(int id)
        {
            Lecture lecture = db.Lectures.Find(id);
            if (lecture != null)
                db.Lectures.Remove(lecture);

            Save();
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public IEnumerable<Lecture> GetModels()
        {
            return db.Lectures;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
