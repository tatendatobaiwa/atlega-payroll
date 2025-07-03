using AtlegaPayroll.Models;
using Microsoft.EntityFrameworkCore;

namespace AtlegaPayroll.Data;

public class AtlegaPayrollDbContext : DbContext
{
    public AtlegaPayrollDbContext(DbContextOptions<AtlegaPayrollDbContext> options) : base(options)
    {
    }

    public DbSet<Company> Companies { get; set; }
    public DbSet<Employee> Employees { get; set; }
}
