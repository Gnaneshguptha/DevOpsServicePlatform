namespace DevOpsPlatform.Application.Interfaces.Services;
using DevOpsServicePlatform.Application.DTOS;

public interface IDevProjectService
{
    Task<IEnumerable<DevProjectDto>> GetAllProjectsAsync(string userId);
    Task<DevProjectDto?> GetProjectByIdAsync(int id, string userId);
    Task<int> CreateProjectAsync(DevProjectDto projectDto, string userId);
}
