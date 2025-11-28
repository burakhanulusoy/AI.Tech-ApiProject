using AiTech.WebUI.DTOs.ProjectDtos;

namespace AiTech.WebUI.Services.ProjectServices
{
    public interface IProjectService
    {
        Task<List<ResultProjectDto>> GetAllAsync();
        Task<UpdateProjectDto> GetByIdAsync(int id);
        Task CreateAsync(CreateProjectDto createProject);
        Task DeleteAsync(int id);
        Task UpdateAsync(UpdateProjectDto updateProject);
        


    }
}
