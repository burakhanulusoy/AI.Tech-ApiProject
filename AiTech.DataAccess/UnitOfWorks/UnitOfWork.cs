
using AiTech.DataAccess.Context;

namespace AiTech.DataAccess.UnitOfWorks
{
    public class UnitOfWork(AppDbContext _context) : IUnitOfWork
    {
        public async Task<bool> SaveChangesAsync()
        {
            //savechangesasync int donuyor, degısen satır sayısını
            return await _context.SaveChangesAsync() > 0;

            //geriye birden fazla degısılık var mı?
        }



    }
}
