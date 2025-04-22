using DevOpsServicePlatform.Domain;
using Microsoft.EntityFrameworkCore;

namespace DevOpsPlatform.Infrastructure.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<DevProject> DevProjects => Set<DevProject>();
    public DbSet<DeploymentPipeline> DeploymentPipelines => Set<DeploymentPipeline>();
}
