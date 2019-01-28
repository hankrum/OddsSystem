using Microsoft.EntityFrameworkCore;
using OddsSystem.Data.Model;
using System;

namespace OddsSystem.Data
{
    public interface IMsSqlDbContext : IDisposable
    {
        DbSet<SportEvent> SportEvents { get; set; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        int SaveChanges();
    }
}
