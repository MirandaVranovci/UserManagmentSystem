using Microsoft.AspNetCore.Identity;

namespace UserManagmentSystem.Models.Domain
{
    public class ApplicationUsers : IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
