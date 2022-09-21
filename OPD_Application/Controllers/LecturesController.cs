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
    public class LecturesController : ControllerBase
    {
        private IRepository<Lecture> db;
        private ILogger<LecturesController> logger;

        public LecturesController(ILogger<LecturesController> logger)
        {
            logger = logger;
            db = new LectureRepository();
        }

        // GET: api/Lecture/{id}
        [HttpGet("{id}")]
        public async Task<Object> GetLecture(int id)
        {
            return db.GetModel(id);
        }

        // GET: api/Lectures
        [HttpGet]
        public async Task<Object> GetLectures()
        {
            return db.GetModels();
        }

        // POST: api/Lecture
        [HttpPost]
        public async Task<Object> PostLector(Lecture lecture)
        {
            db.Create(lecture);

            return CreatedAtAction("GetLecture", new { id = lecture.Id }, lecture);
        }

        // PUT: api/Lectures
        [HttpPut]
        public async Task<Object> PutLecture(Lecture lecture)
        {
            db.Update(lecture);
            return CreatedAtAction("GetLecture", new { id = lecture.Id }, lecture);
        }

        // DELETE: api/Lectures/5
        [HttpDelete("{id}")]
        public async Task<Object> DeleteLecture(int id)
        {
            var lecture = db.GetModel(id);
            if (lecture == null)
            {
                return NotFound();
            }

            db.Delete(id);

            return lecture;
        }


    }
}