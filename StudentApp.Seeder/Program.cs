using StudentApp.DataModel.Models;

namespace StudentApp.Seeder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new EfContext();
            Console.WriteLine("Dodaj nowych studentów i kursy");

            var students = new[]
            {
                new Student(){ Name = "John Doo", Address = "Wenedow 5", City = "Koszalin", PhoneNumber = "123456789", Email = "mail@gmail.com", CourseId = 1 },
                new Student(){ Name = "Michael Jordan", Address = "Adres", City = "Chicago", PhoneNumber = "123456789", Email = "mail@gmail.com", CourseId = 1 }

            };
            foreach (var s in students)
            {
                context.Students.Add(s);
            }

            var courses = new[]
            {
                new Course(){ CourseName = "C# in nutshell"},
                //ok
               
                //     jeden student - jeden kurs, jeden kurs - wielu studentow
            };

            foreach (var c in courses)
            {
                context.Courses.Add(c);
            }

            context.SaveChanges();
        }
    }
}