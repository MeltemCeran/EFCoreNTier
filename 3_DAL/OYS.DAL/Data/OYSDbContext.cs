using Microsoft.EntityFrameworkCore;
using OYS.DAL.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OYS.DAL.Data
{
    public class OYSDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Lesson> lessons { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<University> universities { get; set; }

      

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            /*
            Data Source=LAPTOP-3HH2461E;Initial Catalog=OYSDb;Integrated 
            Security=True;Encrypt=False

            Server=LAPTOP-3HH2461E;Database=OYSDb;Trusted_Connection=True;Encrypt=No;

            3 farklı connection string kullanımı gördük. ÜStteki ikisi birde alttaki. Alttakini SQL Server Object Explorerdan yaptık. En üstteki Server Explorerdan. Ortadaki elle yazmalı.
             */
            string connStr = "Data Source=LAPTOP-3HH2461E;Database=OYSDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            optionsBuilder.UseSqlServer(connStr);
        }
    }
}
