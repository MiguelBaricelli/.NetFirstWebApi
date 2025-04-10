using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using WebApplication1.Model;

namespace WebApplication1.Infraestutura
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Employee>    Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("");
        }

    }
}
