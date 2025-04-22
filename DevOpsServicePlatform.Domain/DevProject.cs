namespace DevOpsServicePlatform.Domain;

public class DevProject
{   
    public int Id { get; set; }
    public string ProjectName { get; set; } = string.Empty;
    public string GitRepositoryUrl { get; set; } = string.Empty;
    public string TargetFramework { get; set; } = string.Empty;
    public string OwnerUserId { get; set; } = string.Empty;
    public DateTime CreatedOnUtc { get; set; } = DateTime.UtcNow;

    public ICollection<DeploymentPipeline> Pipelines { get; set; } = new List<DeploymentPipeline>();
}

public enum PipelineStatus
{
    Queued,
    Running,
    Success,
    Failed
}
