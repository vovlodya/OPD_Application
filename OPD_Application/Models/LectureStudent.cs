using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDBEF
{
    public class LectureStudent
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int LectureId { get; set; }
        public Lecture Lecture { get; set; }

        public LectureStudent() { }

        public LectureStudent(int LectureId, int StudentId)
        {
            this.StudentId = StudentId;
            this.LectureId = LectureId;
        }

        public LectureStudent(int Id, int LectureId, int StudentId)
        {
            this.Id = Id;
            this.StudentId = StudentId;
            this.LectureId = LectureId;
        }
    }
}
