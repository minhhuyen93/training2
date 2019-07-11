namespace TinyERP.Common.Common.Data
{
    using System.Data.Entity;
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private IDbContext dbContext;
        protected IDbSet<TEntity> DbSet { get; private set; }
        public BaseRepository() : this(DbContextFactory.CreateContext<TEntity>())
        {
        }

        public BaseRepository(IDbContext dbContext)
        {
            this.DbSet = dbContext.GetDbSet<TEntity>();
            this.dbContext = dbContext;
        }

        public static IDbContext Create<IDbContextType>() where IDbContextType : IDbContext
        {
            return DbContextFactory.Create<IDbContextType>();
        }

        public void Add(TEntity entity)
        {
            this.DbSet.Add(entity);
        }
    }
}
