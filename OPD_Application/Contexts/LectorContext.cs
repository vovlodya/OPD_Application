using Microsoft.EntityFrameworkCore;
using PDBEF;

namespace OPD_Application.Contexts
{
    public class LectorContext : DbContext
    {
        private string ConnectionString;

        public LectorContext(string connectionString)
        {
            this.ConnectionString = connectionString; 
        }
        public DbSet<Lector> Lectors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString); // подключение базы данных
            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Error); // добавляем логгер
        }
    }
}
