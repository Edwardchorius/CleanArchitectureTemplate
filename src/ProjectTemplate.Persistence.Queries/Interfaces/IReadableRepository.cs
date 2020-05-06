using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTemplate.Persistence.Queries.Interfaces
{
    public interface IReadableRepository<TEntity>
        where TEntity : class
    {
        Task<IReadOnlyList<TEntity>> GetAllAsync();

        // Other methods for retrieving data, could be based on specification pattern
    }
}
