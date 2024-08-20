using System.ComponentModel.DataAnnotations;

namespace KeepMyProcess.Database.Entities
{
    public class BackupLocation : BaseEntity
    {
        [MaxLength(225)] public string Name { get; set; }
        [Required][MaxLength(5000)] public string Path { get; set; }
    }
}
