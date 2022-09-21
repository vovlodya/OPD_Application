using Microsoft.EntityFrameworkCore;
using PDBEF;

namespace OPD_Application.Contexts
{
    public class LectureContext : DbContext
    {
        private string ConnectionString;

        public LectureContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }
        public DbSet<Lecture> Lectures { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString); // подключение базы данных
            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Error); // добавляем логгер
        }
    }
}
