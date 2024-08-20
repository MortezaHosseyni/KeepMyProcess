using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using KeepMyProcess.Database.Enums.UploadLocation;

namespace KeepMyProcess.Database.Entities
{
    public class UploadLocation : BaseEntity
    {
        [Required][MaxLength(225)] public string Name { get; set; }

        [Required][MaxLength(5000)] public string HostAddress { get; set; }
        [Required] public int Port { get; set; }

        [Required][MaxLength(225)] public string Username { get; set; }
        [Required][MaxLength(1000)][PasswordPropertyText] public string Password { get; set; }

        public Protocol Protocol { get; set; }
    }
}
