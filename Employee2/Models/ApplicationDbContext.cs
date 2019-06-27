using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace Employee2.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<BloodGroup> BloodGroups { get; set; }
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}