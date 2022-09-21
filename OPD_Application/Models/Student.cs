using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDBEF
{
    public class Student : User
    {
        public int YearOfEntry { get; set; } // год поступления

        public List<LectorStudent> Lectors { get; set; } = new(); // преподаватели студента

        public List<LectureStudent> AttendedLectures { get; set; } = new(); // лекции, посещенные студентом студента

        public Student() : base() { }

        public Student(string name, string surname, int yearOfEntry)
            : base(name, surname)
        {
            this.YearOfEntry = yearOfEntry;
        }

        public Student(int id, string name, string surname, int yearOfEntry)
           : base(id, name, surname)
        {
            this.YearOfEntry = yearOfEntry;
        }
    }
}
