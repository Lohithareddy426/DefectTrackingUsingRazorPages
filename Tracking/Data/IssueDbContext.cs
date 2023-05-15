using Microsoft.EntityFrameworkCore;
using Tracking.Models;

namespace Tracking.Data
{
    public class IssueDbContext : DbContext
    {
        public IssueDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Issue> Issues { get; set; }
            
    }
}
