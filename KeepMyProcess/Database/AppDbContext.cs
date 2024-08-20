using Microsoft.EntityFrameworkCore;
using KeepMyProcess.Database.Entities;

namespace KeepMyProcess.Database
{
    public class AppDbContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<BackupLocation> BackupLocations { get; set; }
        public DbSet<UploadLocation> UploadLocations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {
            optionsBuilder.UseSqlite("Data Source=KeepMyProcess.db");
        }
    }
}
