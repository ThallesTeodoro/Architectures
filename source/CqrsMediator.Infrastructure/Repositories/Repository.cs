using CqrsMediator.Domain.Contracts.Repositories;
using CqrsMediator.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CqrsMediator.Infrastructure.Repositories;

public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
{
    protected readonly ApplicationDbContext _dbContext;

    public Repository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public virtual void Add(TEntity entity)
    {
        _dbContext.Add(entity);
    }

    public virtual async Task<List<TEntity>> AllAsync()
    {
        return await _dbContext
            .Set<TEntity>()
            .ToListAsync();
    }

    public virtual async Task<int> CountAsync()
    {
        return await _dbContext
            .Set<TEntity>()
            .CountAsync();
    }

    public virtual async Task<TEntity?> FindByIdAsync(Guid id)
    {
        return await _dbContext
            .Set<TEntity>()
            .FindAsync(id);
    }

    public virtual void Remove(TEntity entity)
    {
        _dbContext
            .Set<TEntity>()
            .Remove(entity);
    }

    public virtual void Update(TEntity entity)
    {
        _dbContext
            .Set<TEntity>()
            .Update(entity);
    }
}
