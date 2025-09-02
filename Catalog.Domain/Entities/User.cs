using System.ComponentModel.DataAnnotations;

namespace Catalog.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }

        [Required, MaxLength(150)]
        public string Email { get; set; } = null!;

        [Required, MaxLength(225)]
        public string PasswordHash { get; set; } = null!;

        [Required, MaxLength(20)]
        public string Rol { get; set; } = null!; 

        public DateTime CreatedAt { get; set; }
    }
}