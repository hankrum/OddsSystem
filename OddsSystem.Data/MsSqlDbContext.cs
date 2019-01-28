using Microsoft.EntityFrameworkCore;
using OddsSystem.Data.Model;

namespace OddsSystem.Data
{
    public class MsSqlDbContext : DbContext, IMsSqlDbContext
    {
        public MsSqlDbContext(DbContextOptions<MsSqlDbContext> options)
            : base(options)
        {
        }

        public DbSet<SportEvent> SportEvents { get; set; }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

        public new DbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }
    }
}
