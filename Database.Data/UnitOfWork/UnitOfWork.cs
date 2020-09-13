using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Database.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        protected DbContext Context { get; }

        public UnitOfWork(DbContext context)
        {
            Context = context;
        }

        public virtual async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
            => await Context.SaveChangesAsync(cancellationToken);

        public virtual int SaveChanges()
            => Context.SaveChanges();

        public virtual int SaveChanges(bool acceptAllChangesOnSuccess)
            => Context.SaveChanges(acceptAllChangesOnSuccess);
    }
}
