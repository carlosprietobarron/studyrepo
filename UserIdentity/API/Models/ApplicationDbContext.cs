using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UserIdentity.Api.Models;

namespace UserIdentity.API.Models
{
    public class ApplicationDbContext :
  IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions options)
        : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
    }
}

