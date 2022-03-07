#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MaNguonMo.Models;
namespace MaNguonMo.Data{
     public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }

        public DbSet<Student> Student { get; set; }

        public DbSet<Person> Person { get; set; }

        public DbSet<Employee> Employee { get; set; }

        public DbSet<MaNguonMo.Models.Customer> Customer { get; set; }

    }
}
   
