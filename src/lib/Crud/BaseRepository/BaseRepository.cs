using System.Collections.Generic;
using System.Linq;
using System.Threading;

using Microsoft.EntityFrameworkCore;

using Crud.BaseContext;
using Crud.Utilities;

namespace Crud.BaseRepository
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly BaseDbContext DbContext;

        public DbSet<TEntity> Entities { get; }
        public virtual IQueryable<TEntity> Table => Entities;
        public virtual IQueryable<TEntity> TableNoTracking => Entities.AsNoTracking();

        public BaseRepository(BaseDbContext dbContext)
        {
            DbContext = dbContext;
            Entities = DbContext.Set<TEntity>();
        }

        public virtual List<TEntity> GetByList()
        {
            return TableNoTracking.ToList();
        }

        public virtual TEntity GetById(params object[] id)
        {
            return Entities.Find(id);
        }

        public virtual void Add(TEntity entity, bool saveNow = true)
        {
            Assert.NotNull<TEntity>(entity, nameof(entity));
            Entities.Add(entity);
            if (saveNow)
                DbContext.SaveChanges();
        }

        public virtual void Update(TEntity entity, bool saveNow = true)
        {
            Assert.NotNull<TEntity>(entity, nameof(entity));
            Entities.Update(entity);
            if (saveNow)
                DbContext.SaveChanges();
        }
        public virtual void Delete(TEntity entity, bool saveNow = true)
        {
            Assert.NotNull<TEntity>(entity, nameof(entity));
            Entities.Remove(entity);
            if (saveNow)
                DbContext.SaveChanges();
        }

    }
}