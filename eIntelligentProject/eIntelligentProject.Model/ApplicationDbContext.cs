using eIntelligentProject.Model.Domain;
using Microsoft.EntityFrameworkCore;

namespace eIntelligentProject.Model
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {

        }

        public DbSet<Client> Client { get; set; }
        public DbSet<Interest> Interest { get; set; }
    }
}
