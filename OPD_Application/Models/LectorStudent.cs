using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDBEF
{
    public class LectorStudent
    {

        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int LectorId { get; set; }
        public Lector Lector { get; set; }

        public LectorStudent() { }

        public LectorStudent(int LectorId, int StudentId)
        {
            this.StudentId = StudentId;
            this.LectorId = LectorId;
        }

        public LectorStudent(int id, int LectorId, int StudentId)
        {
            this.Id = id;
            this.StudentId = StudentId;
            this.LectorId = LectorId;
        }
    }
}
