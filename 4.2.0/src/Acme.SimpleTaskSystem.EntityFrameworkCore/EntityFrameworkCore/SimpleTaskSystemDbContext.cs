using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Acme.SimpleTaskSystem.EntityFrameworkCore
{
    public class SimpleTaskSystemDbContext : AbpDbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public SimpleTaskSystemDbContext(DbContextOptions<SimpleTaskSystemDbContext> options) 
            : base(options)
        {

        }
    }
}
