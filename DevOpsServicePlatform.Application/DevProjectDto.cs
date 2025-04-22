namespace DevOpsServicePlatform.Application.DTOS;

public class DevProjectDto
{
    public int Id { get; set; }
    public string ProjectName { get; set; } = string.Empty;
    public string GitRepositoryUrl { get; set; } = string.Empty;
    public string TargetFramework { get; set; } = string.Empty;
}
