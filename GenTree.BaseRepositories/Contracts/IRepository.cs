using System.Collections.Generic;

namespace GenTree.BaseRepositories.Contracts
{
    public interface IRepository<TEntity, TId> where TEntity : class, IEntity<TId>
        where TId : class, new()
    {
        TEntity GetById(TId id);

        TId Save(TEntity entity);

        IEnumerable<TEntity> GetAll();

        void Delete(TId id);
    }
}
