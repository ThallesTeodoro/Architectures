namespace CqrsMediator.Domain.Contracts.Repositories;

public interface IRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// Add new entity
        /// </summary>
        /// <param name="entity">Entity instance</param>
        void Add(TEntity entity);

        /// <summary>
        /// Get entity by id
        /// </summary>
        /// <param name="id">Entity id</param>
        /// <returns>Entity instance</returns>
        Task<TEntity?> FindByIdAsync(Guid id);

        /// <summary>
        /// Count all async
        /// </summary>
        /// <returns>Entities total</returns>
        Task<int> CountAsync();

        /// <summary>
        /// Get all entities
        /// </summary>
        /// <returns>List of entities</returns>
        Task<List<TEntity>> AllAsync();

        /// <summary>
        /// Update an entity
        /// </summary>
        /// <param name="entity">Entity instance</param>
        void Update(TEntity entity);

        /// <summary>
        /// Remove entity
        /// </summary>
        /// <param name="entity">Entity instance</param>
        void Remove(TEntity entity);
    }
