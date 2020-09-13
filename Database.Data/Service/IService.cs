using Database.Data.Repository;

namespace Database.Data.Service
{
    public interface IService<TEntity> : IRepository<TEntity> where TEntity : class
    {
    }
}
