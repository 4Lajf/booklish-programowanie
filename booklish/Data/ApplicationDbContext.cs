using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using booklish.Models;

namespace booklish.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<booklish.Models.Books>? Books { get; set; }
        public DbSet<booklish.Models.Orders>? Orders { get; set; }
		public DbSet<booklish.Models.User>? User { get; set; }
	}
}