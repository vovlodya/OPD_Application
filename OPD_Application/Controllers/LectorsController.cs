using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OPD_Application.Models;
using OPD_Application.Repositories;
using PDBEF;
using System.Diagnostics;

namespace OPD_Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LectorsController : ControllerBase
    {
        private IRepository<Lector> db;

        public LectorsController()
        {
            db = new LectorRepository();
        }

        // GET: api/Lector/{id}
        [HttpGet("{id}")]
        public async Task<Object> GetLector(int id)
        {
            return db.GetModel(id);
        }

        // GET: api/Lectors
        [HttpGet]
        public async Task<Object> GetLectors()
        {
            return db.GetModels();
        }

        // POST: api/Lectors
        [HttpPost]
        public async Task<Object> PostLector(Lector lector)
        {
            db.Create(lector);
            return CreatedAtAction("GetLector", new { id = lector.Id }, lector);
        }

        // PUT: api/Lectors
        [HttpPut]
        public async Task<Object> PutLector(Lector lector)
        {
            db.Update(lector);
            return CreatedAtAction("GetLector", new { id = lector.Id }, lector);
        }

        // DELETE: api/Lectors/{id}
        [HttpDelete("{id}")]
        public async Task<Object> DeleteLector(int id)
        {
            var lector = db.GetModel(id);
            if (lector == null)
            {
                return NotFound();
            }

            db.Delete(id);

            return lector;
        }


    }
}