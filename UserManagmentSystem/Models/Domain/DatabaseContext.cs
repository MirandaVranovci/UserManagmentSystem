using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace UserManagmentSystem.Models.Domain
{
    public class DatabaseContext : IdentityDbContext<ApplicationUsers>
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) 
        {

        }
    }
}
