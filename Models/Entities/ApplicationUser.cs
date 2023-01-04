using Microsoft.AspNetCore.Identity;
using Microsoft.Build.Framework;

namespace HIN_Ventures.Models.Entities
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string? AccountAddress { get; set; }
    }
}
