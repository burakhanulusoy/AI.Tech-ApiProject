using AiTech.DataAccess.Repositories.GenericRepositories;
using AiTech.Entity.Entities;

namespace AiTech.DataAccess.Repositories.ProjectRepositories
{
    public interface IProjectRepository:IRepository<Project>
    {

        Task<List<Project>> GetProjectsWithCatgeoriesAsync();






    }
}
