using Microsoft.EntityFrameworkCore;
using PDBEF;

namespace OPD_Application.Contexts
{
    public class StudentContext : DbContext
    {
        private string ConnectionString;

        public StudentContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString); // подключение базы данных
            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Error); // добавляем логгер
        }
    }
}
