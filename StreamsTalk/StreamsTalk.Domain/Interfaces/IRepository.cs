using StreamsTalk.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StreamsTalk.Domain.Interfaces
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        Task<List<TEntity>> GetAll();

        Task<TEntity> Get(string id);

        Task Insert(TEntity entity);

        Task Update(string id, TEntity entity);

        Task Delete(string id);
        Task<bool> IsExists(string id);
    }
}
