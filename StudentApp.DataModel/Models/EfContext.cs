using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.DataModel.Models
{
    public  class EfContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=studentdb2;Integrated Security=True";
            optionsBuilder.UseSqlServer(connectionString);
            //Get-Service | Where {$_.status -eq 'running' -and $_.DisplayName -match "sql server*"}

        }
    }
}