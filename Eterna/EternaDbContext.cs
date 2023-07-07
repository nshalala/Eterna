using Eterna.Models;
using Microsoft.EntityFrameworkCore;

namespace Eterna
{
    public class EternaDbContext:DbContext
    {
        public EternaDbContext(DbContextOptions<EternaDbContext> options):base(options)
        {
            
        }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }
    }
}
