using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;

namespace MeControla.StockAnalytics.DataStorage
{
    public class DbAppContextFactory : IDesignTimeDbContextFactory<DbAppContext>, IDisposable
    {
        private const string CONNECTION_STRING = "Data Source=storage.db";

        private DbAppContext context;

        public DbAppContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DbAppContext>();
            optionsBuilder.UseSqlite(CONNECTION_STRING);

            return new DbAppContext(optionsBuilder.Options); ;
        }

        public void Dispose()
        {
            context?.Dispose();

            GC.SuppressFinalize(this);
        }
    }
}