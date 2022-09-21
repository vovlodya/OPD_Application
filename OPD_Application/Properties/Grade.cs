using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDBEF
{
    public class Grade
    {
        public int Id { get; set; }

        public int Score { get; set; } // оценка за домашнюю работу

        // ==== FK Student (студент, которому выставлена оценка) ====
        public int StudentId { get; set; }

        public Student Student { get; set; }
        // ==== FK Student ====

        // ==== FK Homework (домашняя работа, за которую выставлена оценка) ====
        public int HomeworkId { get; set; }

        public Homework Homework { get; set; }
        // ==== FK Homework ====

        public Grade(int id, int score, int studentId, int homeworkId)
        {
            this.Id = id;
            this.Score = score;
            this.HomeworkId = homeworkId;
            this.StudentId = studentId;
        }

        public Grade(int score, int studentId, int homeworkId)
        {
            this.Score = score;
            this.HomeworkId = homeworkId;
            this.StudentId = studentId;
        }

        public Grade(int id, int score, Student student, Homework homework)
        {
            this.Id = id;
            this.Score = score;
            this.Homework = homework;
            this.Student = student;
        }

        public Grade(int score, Student student, Homework homework)
        {
            this.Score = score;
            this.Homework = homework;
            this.Student = student;
        }
    }
}
