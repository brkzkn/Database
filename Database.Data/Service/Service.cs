using Database.Data.Query;
using Database.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace Database.Data.Service
{
    public abstract class Service<TEntity> : IService<TEntity> where TEntity : class
    {
        protected readonly IRepository<TEntity> Repository;

        protected Service(IRepository<TEntity> repository)
            => Repository = repository;

        public virtual void Attach(TEntity item)
            => Repository.Attach(item);

        public virtual void Delete(TEntity item)
            => Repository.Delete(item);

        public virtual async Task<bool> DeleteAsync(object[] keyValues, CancellationToken cancellationToken = default)
            => await Repository.DeleteAsync(keyValues, cancellationToken);

        public virtual async Task<bool> DeleteAsync<TKey>(TKey keyValue, CancellationToken cancellationToken = default)
            => await Repository.DeleteAsync(keyValue, cancellationToken);

        public virtual void Detach(TEntity item)
            => Repository.Detach(item);

        public virtual async Task<bool> ExistsAsync(object[] keyValues, CancellationToken cancellationToken = default)
            => await Repository.ExistsAsync(keyValues, cancellationToken);

        public virtual async Task<bool> ExistsAsync<TKey>(TKey keyValue, CancellationToken cancellationToken = default)
            => await Repository.ExistsAsync(keyValue, cancellationToken);

        public virtual async Task<TEntity> FindAsync(object[] keyValues, CancellationToken cancellationToken = default)
            => await Repository.FindAsync(keyValues, cancellationToken);

        public virtual async Task<TEntity> FindAsync<TKey>(TKey keyValue, CancellationToken cancellationToken = default)
            => await Repository.FindAsync(keyValue, cancellationToken);

        public virtual void Insert(TEntity item)
            => Repository.Insert(item);

        public void InsertRange(IEnumerable<TEntity> entities)
            => Repository.InsertRange(entities);

        public Task InsertRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default)
            => Repository.InsertRangeAsync(entities, cancellationToken);

        public virtual async Task LoadPropertyAsync(TEntity item, Expression<Func<TEntity, object>> property, CancellationToken cancellationToken = default)
            => await Repository.LoadPropertyAsync(item, property, cancellationToken);

        public virtual IQuery<TEntity> Query()
            => Repository.Query();

        public virtual IQueryable<TEntity> Queryable()
            => Repository.Queryable();

        public virtual async Task<IEnumerable<TEntity>> SelectAsync(CancellationToken cancellationToken = default)
            => await Repository.Query().SelectAsync(cancellationToken);

        public virtual void Update(TEntity item)
            => Repository.Update(item);
    }
}
