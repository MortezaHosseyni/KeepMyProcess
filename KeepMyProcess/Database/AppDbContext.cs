using Microsoft.EntityFrameworkCore;
using KeepMyProcess.Database.Entities;

namespace KeepMyProcess.Database
{
    public class AppDbContext : DbContext
    {
        public DbSet<Game> Games { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {
            optionsBuilder.UseSqlite("Data Source=KeepMyProcess.db");
        }
    }
}
