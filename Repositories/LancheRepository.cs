using LanchesMac.Context;
using LanchesMac.Models;
using LanchesMac.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LanchesMac.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        private readonly AppDbContext _dbContext;

        public LancheRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Lanche> Lanches => _dbContext.Lanches
                                                        .Include(c => c.Categoria);
        public IEnumerable<Lanche> LanchesPreferidos => _dbContext.Lanches
                                                                  .Where(l => l.IsLanchePreferido)
                                                                  .Include(c => c.Categoria);
        public Lanche GetLancheById(int id)
        {
            return _dbContext.Lanches.FirstOrDefault(x => x.LancheId == id);
        }
    }
}
