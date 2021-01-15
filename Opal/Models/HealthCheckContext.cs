using Microsoft.EntityFrameworkCore;

namespace Opal.Models
{
    public class HealthCheckContext : DbContext
    {
        public HealthCheckContext(DbContextOptions<HealthCheckContext> options) : base(options)
        {
        }

        public DbSet<HealthCheck> HealthChecks { get; set; }
    }
}