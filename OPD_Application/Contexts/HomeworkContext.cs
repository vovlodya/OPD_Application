using Microsoft.EntityFrameworkCore;
using PDBEF;

namespace OPD_Application.Contexts
{
    public class HomeworkContext : DbContext
    {
        private string ConnectionString;

        public HomeworkContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }
        public DbSet<Homework> Homeworks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString); // подключение базы данных
            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Error); // добавляем логгер
        }
    }
}
