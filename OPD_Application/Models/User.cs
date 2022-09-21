using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDBEF
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public User() { }

        public User(int id, string name, string surname)
        {
            this.Id = id;
            this.Name = name;
            this.Surname = surname;
        }

        public User(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
    }
}
