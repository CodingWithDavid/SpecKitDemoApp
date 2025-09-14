using Microsoft.EntityFrameworkCore;
using managerTracker.Models;

namespace managerTracker.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<EmailTemplate> EmailTemplates { get; set; }
        public DbSet<Contractor> Contractors { get; set; }
        public DbSet<ProjectRelease> ProjectReleases { get; set; }
        public DbSet<FeatureRelease> FeatureReleases { get; set; }
    }
}
