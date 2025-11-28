using AiTech.DataAccess.Context;
using AiTech.Entity.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace AiTech.DataAccess.Repositories.GenericRepositories
{
    public class GenericRepository<Tentity>(AppDbContext context) : IRepository<Tentity> where Tentity : BaseEntity
    {

        protected readonly AppDbContext _context = context;


        public async Task CreateAsync(Tentity entity)
        {
            await _context.AddAsync(entity);
            await  _context.SaveChangesAsync();
        }

        public void Delete(Tentity entity)
        {
           
           _context.Remove(entity);


        }

        public async Task<List<Tentity>> GetAllAsync()
        {
            return await _context.Set<Tentity>().AsNoTracking().ToListAsync();
        }

        public async Task<Tentity> GetByIdAsync(int id)
        {
            return await _context.Set<Tentity>().FindAsync(id);
        }

        public void Update(Tentity entity)
        {
            _context.Update(entity);
        }
    }
}
