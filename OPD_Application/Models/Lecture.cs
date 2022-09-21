using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDBEF
{
    public class Lecture
    {
        public int Id { get; set; }

        // ==== FK Lector ====
        public int LectorId { get; set; }
        //public Lector Lector { get; set; }
        // ==== FK Lector ====

        // ==== FK Lector ====
        public int HomeworkId { get; set; }

        //public Homework Homework { get; set; }
        // ==== FK Lector ====

        public string Date { get; set; }

        public string Title { get; set; }

        public string Url { get; set; }

        public List<LectureStudent> StudentsWhoAttended { get; set; } = new(); // студенты, посетившие лекцию

        public Lecture(string date, string title, string url, Homework homework, Lector lector)
        {
            this.Date = date;
            this.Title = title;
            this.Url = url;
            //this.Homework = homework;
            //this.Lector = lector;
        }

        public Lecture(string date, string title, string url, int homeworkId, int lectorId)
        {
            this.Date = date;
            this.Title = title;
            this.Url = url;
            this.HomeworkId = homeworkId;
            this.LectorId = lectorId;
        }

        public Lecture(int id, string date, string title, string url, Homework homework, Lector lector)
        {
            this.Id = id;
            this.Date = date;
            this.Title = title;
            this.Url = url;
            //this.Homework = homework;
            //this.Lector = lector;
        }

        public Lecture(int id, string date, string title, string url, int homeworkId, int lectorId)
        {
            this.Id = id;
            this.Date = date;
            this.Title = title;
            this.Url = url;
            this.HomeworkId = homeworkId;
            this.LectorId = lectorId;
        }

        public Lecture()
        {

        }
    }
}
