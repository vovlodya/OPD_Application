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
    public class HomeworksController : ControllerBase
    {
        private IRepository<Homework> db;
        private ILogger<HomeworksController> logger;

        public HomeworksController(ILogger<HomeworksController> logger)
        {
            logger = logger;
            db = new HomeworkRepository();
        }

        // GET: api/Homework/{id}
        [HttpGet("{id}")]
        public async Task<Object> GetHomework(int id)
        {
            return db.GetModel(id);
        }

        // GET: api/Homeworks
        [HttpGet]
        public async Task<Object> GetHomeworks()
        {
            return db.GetModels();
        }

        // POST: api/Homeworks
        [HttpPost]
        public async Task<Object> PostHomework(Homework homework)
        {
            db.Create(homework);

            return CreatedAtAction("GetHomework", new { id = homework.Id }, homework);
        }

        // PUT: api/Homeworks
        [HttpPut]
        public async Task<Object> PutHomework(Homework homework)
        {
            db.Update(homework);
            return CreatedAtAction("GetHomework", new { id = homework.Id }, homework);
        }

        // DELETE: api/Homeworks/5
        [HttpDelete("{id}")]
        public async Task<Object> DeleteHomework(int id)
        {
            var homework = db.GetModel(id);
            if (homework == null)
            {
                return NotFound();
            }

            db.Delete(id);

            return homework;
        }


    }
}