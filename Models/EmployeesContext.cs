using Microsoft.EntityFrameworkCore;

namespace EmployeesMVCApp.Models
{
    public class EmployeesContext : DbContext
    {
        public EmployeesContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<EmployeeModel> Employees { get; set; }
    }
}
