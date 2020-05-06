using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectTemplate.Persistence.Queries.Interfaces;

namespace ProjectTemplate.Persistence.Queries.Repositories.Base
{
    public abstract class BaseReadableEfRepository<TEntity> : IReadableRepository<TEntity>
         where TEntity : class
    {
        protected readonly DbContext _readableDbContext;
        public BaseReadableEfRepository(DbContext readableDbContext)
        {
            _readableDbContext = readableDbContext;
        }

        public async Task<IReadOnlyList<TEntity>> GetAllAsync()
        {
            return await _readableDbContext.Set<TEntity>().ToListAsync();
        }
    }
}
