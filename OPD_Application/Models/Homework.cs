using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDBEF
{
    public class Homework
    {
        public int Id { get; set; }
        public string Url { get; set; }

        public List<Lecture> Lectures { get; set; } = new();

        public Homework()
        {

        }
        public Homework(int id, string url)
        {
            this.Id = id;
            this.Url = url;
        }

        public Homework(string url)
        {
            this.Url = url;
        }
    }
}
