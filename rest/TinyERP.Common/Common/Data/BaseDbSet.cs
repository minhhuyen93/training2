using System.Data.Entity;
using System.Linq;
using TinyERP.Common.Common.Exceptions;

namespace TinyERP.Common.Common.Data
{
    public class BaseDbSet<TEntity> where TEntity : class
    {
        private DbContext _dbContext;
        private IOMode _mode;
        private IDbSet<TEntity> dbSet;
        public BaseDbSet(DbContext dbContext, IOMode mode)
        {
            this._dbContext = dbContext;
            this._mode = mode;
            this.dbSet = dbContext.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            if(this._mode == IOMode.ReadOnly)
            {
                throw new UnSupportException("Can not add new Entity");
            }
            this.dbSet.Add(entity);
        }

        public IQueryable<TEntity> AsQueryable()
        {
            return this._mode == IOMode.ReadOnly ? this.dbSet.AsNoTracking<TEntity>() : this.dbSet;
        }

    }
}
