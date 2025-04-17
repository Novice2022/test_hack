using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Hakaton.DTO
{
    public class RegisterUserDto
    {
        [NotNull]
        [MaxLength(100)]
        public string FirstName { get; set; }
        [NotNull]
        [MaxLength(100)]
        public string LastName { get; set; }
        [NotNull]
        [MaxLength(50)]
        public string Login { get; set; }
        [NotNull]
        [MaxLength(257)]
        public string PasswordHash { get; set; }
    }
}
