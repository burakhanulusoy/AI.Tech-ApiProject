using AiTech.DataAccess.Context;
using AiTech.DataAccess.Repositories.GenericRepositories;
using AiTech.Entity.Entities;
using Microsoft.EntityFrameworkCore;

namespace AiTech.DataAccess.Repositories.ProjectRepositories
{
    public class ProjectRepository : GenericRepository<Project>, IProjectRepository
    {
        public ProjectRepository(AppDbContext _context) : base(_context)
        {
  
        }

        public async Task<List<Project>> GetProjectsWithCatgeoriesAsync()
        {
         
           return await _context.Projects.AsNoTracking().Include(x=>x.Category).ToListAsync();//önce olması daha mantıklı



        }



    }
}
