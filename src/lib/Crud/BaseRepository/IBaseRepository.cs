using System.Collections.Generic;

namespace Crud.BaseRepository
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {

        List<TEntity> GetByList();
        TEntity GetById(params object[] ids);
        void Add(TEntity entity, bool saveNow = true);
        void AddRange(IEnumerable<TEntity> entities, bool saveNow = true);
        void Update(TEntity entity, bool saveNow = true);
        void UpdateRange(IEnumerable<TEntity> entities, bool saveNow = true);
        void Delete(TEntity entity, bool saveNow = true);
        void DeleteRange(IEnumerable<TEntity> entities, bool saveNow = true);
    }
}