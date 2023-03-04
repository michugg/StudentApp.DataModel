using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.DataModel.Models
{
    internal class EfContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = @"Data Source=localhost;Initial Catalog=studentdb2;
                                    Integrated Security=True;TrustServerCertificate=True";
            optionsBuilder.UseSqlServer(connectionString);
            //Get-Service | Where {$_.status -eq 'running' -and $_.DisplayName -match "sql server*"}

        }
    }
}
