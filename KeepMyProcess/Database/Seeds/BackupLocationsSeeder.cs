using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using KeepMyProcess.Database.Entities;
using Microsoft.EntityFrameworkCore.Internal;

namespace KeepMyProcess.Database.Seeds
{
    public class BackupLocationsSeeder
    {
        public async Task<bool> Seed()
        {
            try
            {
                var db = new AppDbContext();

                if (!db.BackupLocations.Any())
                {
                    var locations = new List<string>()
                    {
                        "/Backups"
                    };

                    foreach (var location in locations)
                    {
                        await db.BackupLocations.AddAsync(new BackupLocation()
                        {
                            Name = "Local Folder",
                            Path = location,
                            CreatedAt = DateTime.Now,
                            UpdatedAt = DateTime.Now
                        });
                        await db.SaveChangesAsync();
                    }

                    return true;
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
