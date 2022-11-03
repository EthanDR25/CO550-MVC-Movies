using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CO550_MOVIES_MVC.Models;

namespace C0550_MOVIES_MVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CO550_MOVIES_MVC.Models.Movie> Movie { get; set; }
    }
}