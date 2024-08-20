using System.ComponentModel.DataAnnotations;

namespace KeepMyProcess.Database.Entities
{
    public class Game : BaseEntity
    {
        [Required] public string Name { get; set; }
        [Required] public string GamePath { get; set; }
        [Required] public string GameSavePath { get; set; }
    }
}
