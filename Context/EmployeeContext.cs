using AppFactoryEmployees.Models;
using Microsoft.EntityFrameworkCore;

namespace AppFactoryEmployees.Context
{
    public class EmployeeContext : DbContext
    {

        public DbSet<Employees>? Employees { get; set; }
        public DbSet<Salary>? Salaries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data source=(localdb)\\MSSQLLocalDB; Initial Catalog=EmployeesDb");
        }
        
     
    }
}
