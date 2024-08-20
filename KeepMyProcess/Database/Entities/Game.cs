using System.ComponentModel.DataAnnotations;

namespace KeepMyProcess.Database.Entities
{
    public class Game : BaseEntity
    {
        [Required][MaxLength(200)] public string Name { get; set; }
        [Required][MaxLength(10000)] public string GamePath { get; set; }
        [Required][MaxLength(10000)] public string GameSavePath { get; set; }
    }
}
