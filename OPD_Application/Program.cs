using PDBEF;

namespace OPD_Application
{
    public class Program
    {
        static string connectionParams = "Server=(localdb)\\mssqllocaldb;Database=helloappdb;Trusted_Connection=True;";

        public static void Main(string[] args)
        {

			using (ApplicationContext db = new ApplicationContext(connectionParams, Console.WriteLine))
			{
				Console.WriteLine("=================================");
				Console.WriteLine("   CRUD TEST:   ");
				Console.WriteLine("=================================");

				// студенты
				Console.WriteLine("\n ===== STUDENT ===== \n");

				Console.WriteLine("Данные до добавления:");

				var students = db.Students.ToList();

				foreach (var s in students)
				{
					Console.WriteLine($"{s.Id}.{s.Name} - {s.Surname}");
				}


				Student pupa = new Student("CRUD Лупа", "Карасев", 2020);
				Student lupa = new Student("CRUD Лупа", "Карасев", 2020);
				Student vitya = new Student("CRUD Виктор", "Баринов", 2020);

				db.Students.Add(pupa);
				db.Students.Add(lupa);
				db.Students.Add(vitya);
				db.SaveChanges();

				Console.WriteLine("Данные после добавления:");

				var studentsAfter = db.Students.ToList();

				foreach (var s in studentsAfter)
				{
					Console.WriteLine($"{s.Id}.{s.Name} - {s.Surname}");
				}

				// преподаватели
				Console.WriteLine("\n ===== LECTOR ===== \n");

				Console.WriteLine("Данные до добавления:");

				var lectors = db.Lectors.ToList();

				foreach (var s in lectors)
				{
					Console.WriteLine($"{s.Id}.{s.Name} - {s.Surname}");
				}


				var pupa1 = new Lector("CRUD Препод Лупа", "Карасев", 2020);
				var lupa1 = new Lector("CRUD Препод Лупа", "Карасев", 2020);
				var vitya1 = new Lector("CRUD Препод Виктор", "Баринов", 2020);

				pupa1.Students.AddRange(new List<LectorStudent> { new LectorStudent(6, 1), new LectorStudent(6, 2), new LectorStudent(6, 3) });

				db.Lectors.Add(pupa1);
				db.Lectors.Add(lupa1);
				db.Lectors.Add(vitya1);
				db.SaveChanges();

				Console.WriteLine("Данные после добавления:");

				var lectorsAfter = db.Lectors.ToList();

				foreach (var s in lectorsAfter)
				{
					Console.WriteLine($"{s.Id}.{s.Name} - {s.Surname}");
				}

				// Привязка студентов к преподавателям
				Console.WriteLine("\n ===== LECTOR_STUDENT ===== \n");

				Console.WriteLine("Данные:");

				var lectorStudents = db.LectorStudents.ToList();

				foreach (var s in lectorStudents)
				{
					Console.WriteLine($"{s.Id}) Lector (#{s.Lector.Id}) {s.Lector.Name} {s.Lector.Surname} - Student (#{s.Student.Id}) {s.Student.Name} {s.Student.Surname}");
				}
			}

			CreateHostBuilder(args).Build().Run();

		}

		public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}







/*var builder = WebApplication.CreateBuilder();
string connection = builder.Configuration.GetConnectionString("DefaultConnection");
//builder.Services.AddDbContext<>()
    //AddDbContext<ApplicationContext> (options => options.UseSql);
builder.Services.AddControllersWithViews();



var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();*/
