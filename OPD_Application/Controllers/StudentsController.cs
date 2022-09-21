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
    public class StudentsController : ControllerBase
    {
        private IRepository<Student> db;
        private ILogger<StudentsController> logger;

        public StudentsController(ILogger<StudentsController> logger)
        {
            logger = logger;
            db = new StudentRepository();
        }

        // GET: api/Student/{id}
        [HttpGet("{id}")]
        public async Task<Object> GetStudent(int id)
        {
            return db.GetModel(id);
        }

        // GET: api/Students
        [HttpGet]
        public async Task<Object> GetStudent()
        {
            return db.GetModels();
        }

        // POST: api/Students
        [HttpPost]
        public async Task<Object> PostStudent(Student student)
        {

            db.Create(student);

            return CreatedAtAction("GetStudent", new { id = student.Id }, student);
        }

        // PUT: api/Students
        [HttpPut]
        public async Task<Object> PutStudent(Student student)
        {
            db.Update(student);
            return CreatedAtAction("GetStudent", new { id = student.Id }, student);
        }

        // DELETE: api/Students/5
        [HttpDelete("{id}")]
        public async Task<Object> DeleteStudent(int id)
        {
            var student = db.GetModel(id);
            if (student == null)
            {
                return NotFound();
            }

            db.Delete(id);

            return student;
        }


    }
}