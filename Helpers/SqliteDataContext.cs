using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace WebApi.Helpers
{
    public class SqliteDataContext : DataContext
    {
        public SqliteDataContext(IConfiguration configuration) : base(configuration) { }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // conecta no banco de dados do SQLite (era esse n� Jonas?)
            options.UseSqlite(Configuration.GetConnectionString("WebApiDatabase"));
        }
    }
}