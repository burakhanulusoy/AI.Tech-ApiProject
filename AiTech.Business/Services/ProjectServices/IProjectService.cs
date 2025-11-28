using AiTech.Business.Services.GenericServices;
using AiTech.DTO.ProjectDtos;
using AiTech.Entity.Entities;

namespace AiTech.Business.Services.ProjectServices
{
    public interface IProjectService:IGenericService<ResultProjectDto,CreateProjectDto,UpdateProjectDto>
    {


        Task<List<ResultProjectDto>> TGetProjectsWithCatgeoriesAsync();

    }
}
