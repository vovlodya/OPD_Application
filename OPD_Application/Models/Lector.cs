using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDBEF
{
    public class Lector : User
    {
        public int WorkingSince { get; set; } // год начала работы

        public List<LectorStudent> Students { get; set; } = new(); // слушатели преподавателя

        public List<Lecture> Lectures { get; set; } = new(); // лекции, закрепленные за преподавателем

        public Lector() : base() { }

        public Lector(string name, string surname, int workingSince)
            : base(name, surname)
        {
            this.WorkingSince = workingSince;
        }

        public Lector(int id, string name, string surname, int workingSince)
           : base(id, name, surname)
        {
            this.WorkingSince = workingSince;
        }
    }
}
