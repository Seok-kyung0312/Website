using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using INFORMATIONS.Models;

namespace INFORMATIONS.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<INFORMATIONS.Models.Profile> Profile { get; set; } = default!;
        public DbSet<Comment> Comments { get; set; }
    }
}
