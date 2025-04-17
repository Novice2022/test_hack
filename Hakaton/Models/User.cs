using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Hakaton.Models
{
    public class User
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(50)]
        public string Login {  get; set; }
        [Required]
        [MaxLength(257)]
        public string PasswordHash { get; set; }
        [Required]
        public DateTime RegistrationDate { get; set; }
    }
}
