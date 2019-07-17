using System.Data.Entity;

namespace TinyERP.Common.Common.Data
{
    public class BaseDbContext : DbContext
    {
        public BaseDbContext(string connectionString) : base(connectionString)
        { }
        public BaseDbSet<TEntity> GetDbSet<TEntity>(IOMode mode) where TEntity : class
        {
            return new BaseDbSet<TEntity>(this, mode);
        }
    }
}
