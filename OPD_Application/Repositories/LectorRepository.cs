using PDBEF;
using Microsoft.EntityFrameworkCore;
using OPD_Application.Contexts;
using OPD_Application.Exceptions;

namespace OPD_Application.Repositories
{
    public class LectorRepository : IRepository<Lector>
    {
        private LectorContext db;

        public LectorRepository()
        {
            this.db = new LectorContext("Server=(localdb)\\mssqllocaldb;Database=helloappdb;Trusted_Connection=True;"); 
        }

        public Lector GetModel(int id)
        {
            return db.Lectors.Find(id);
        }

        public void Create(Lector lector)
        {
            db.Lectors.Add(lector);
            Save();
        }

        public void Update(Lector lector)
        {
            if (!db.Lectors.Select(x => x.Id).ToArray().Contains(lector.Id))
            {
                throw new LectorNotFoundException("Lector not found");
            }
            db.Lectors.Update(lector);
            Save();
        }

        public void Delete(int id)
        {
            Lector lector = db.Lectors.Find(id);
            if (lector != null)
                db.Lectors.Remove(lector);

            Save();
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public IEnumerable<Lector> GetModels()
        {
            return db.Lectors;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
