using System.Collections.Generic;
using System.Threading.Tasks;

namespace eTickets.Data.Base
{
    public interface IBaseEntityRepository<T> where T: class, IBaseEntity, new()
    {
        Task<IEnumerable<T>> GetAllAsync();

        Task<T> GetByIdAsync(int id);

        Task AddAsync(T entity);

        Task<T> UpdateAsync(int id, T entity);

        Task DeleteAsync(int id);
    }
}
