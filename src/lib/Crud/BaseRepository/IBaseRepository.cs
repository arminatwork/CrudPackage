using System.Collections.Generic;

namespace Crud.BaseRepository
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        List<TEntity> GetByList();

        // List<TEntity> GetByList(Expression<Func<TEntity, bool>condidate, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>>);

        TEntity GetById(params object[] id);
        void Add(TEntity entity, bool saveNow = true);
        void Update(TEntity entity, bool saveNow = true);
        void Delete(TEntity entity, bool saveNow = true);
    }
}