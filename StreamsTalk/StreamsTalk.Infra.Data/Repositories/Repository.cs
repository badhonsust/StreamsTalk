using Microsoft.EntityFrameworkCore;
using StreamsTalk.Domain.Entities;
using StreamsTalk.Infra.Data.Context;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StreamsTalk.Infra.Data.Repositories
{
    public class Repository<TEntity> where TEntity : Entity
    {
        private readonly StreamsTalkDbContext _dbContext;
        public Repository(StreamsTalkDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task Delete(string id)
        {
            var entity = await Get(id);
            _dbContext.Set<TEntity>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<TEntity> Get(string id)
        {
            return await _dbContext.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
        }

        public  Task<List<TEntity>> GetAll()
        {
            return  _dbContext.Set<TEntity>().ToListAsync();
        }

        public async Task Insert(TEntity entity)
        {
            await _dbContext.Set<TEntity>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<bool> IsExists(string id)
        {
            return  _dbContext.Set<TEntity>().Any(e => e.Id == id);
        }

        public async Task Update(string id, TEntity entity)
        {
            _dbContext.Set<TEntity>().Update(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}
