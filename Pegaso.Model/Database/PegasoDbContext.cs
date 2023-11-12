using Microsoft.EntityFrameworkCore;
using Pegaso.Model.Database.Model;

namespace Pegaso.Model.Database
{
    public class PegasoDbContext : DbContext
    {
        public PegasoDbContext(DbContextOptions<PegasoDbContext> options)
            : base(options)
        {

        }
        public DbSet<Employee> Employee { get; set; }
    }
}
