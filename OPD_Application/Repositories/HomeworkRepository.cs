using PDBEF;
using Microsoft.EntityFrameworkCore;
using OPD_Application.Contexts;
using OPD_Application.Exceptions;

namespace OPD_Application.Repositories
{
    public class HomeworkRepository : IRepository<Homework>
    {
        private HomeworkContext db;

        public HomeworkRepository()
        {
            this.db = new HomeworkContext("Server=(localdb)\\mssqllocaldb;Database=helloappdb;Trusted_Connection=True;");
        }

        public Homework GetModel(int id)
        {
            return db.Homeworks.Find(id);
        }

        public void Create(Homework homework)
        {
            db.Homeworks.Add(homework);
            Save();
        }

        public void Update(Homework homework)
        {
            if (!db.Homeworks.Select(x => x.Id).ToArray().Contains(homework.Id))
            {
                throw new HomeworkNotFoundException("Homework not found");
            }

            db.Homeworks.Update(homework);
            Save();
        }

        public void Delete(int id)
        {
            Homework homework = db.Homeworks.Find(id);
            if (homework != null)
                db.Homeworks.Remove(homework);

            Save();
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public IEnumerable<Homework> GetModels()
        {
            return db.Homeworks;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

    }
}
