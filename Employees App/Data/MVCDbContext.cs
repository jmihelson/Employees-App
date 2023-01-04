using Employees_App.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Employees_App.Data
{
    public class MVCDbContext : DbContext
    {
        public MVCDbContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<Employee> Employees { get; set; }
    }
}
