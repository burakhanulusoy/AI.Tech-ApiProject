using AiTech.Entity.Entities.Common;

namespace AiTech.DataAccess.Repositories.GenericRepositories
{
    public interface IRepository<Tentity> where Tentity : BaseEntity
    {

        Task<List<Tentity>> GetAllAsync(); 
        Task<Tentity> GetByIdAsync(int id);
        Task CreateAsync(Tentity entity);
        void Update(Tentity entity);
        void Delete(Tentity entity);
       

    }
}
