using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Vaegt_Library;
using Vaegt_Library.Vaegt_Library;

namespace Vaegt_Control.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<MaalsaetningModel> Maalsaetninger { get; set; }
        public DbSet<WeightEntry> WeightEntries { get; set; }
    }
}