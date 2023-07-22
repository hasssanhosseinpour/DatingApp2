
using System.ComponentModel.DataAnnotations;

namespace APISide.Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
    }
    // public class EFMigrationsHistory
    // {
    //     [Key]
    //     public string MigrationId { get; set; }
    //     public string ProductVersion { get; set; }
    // }
}