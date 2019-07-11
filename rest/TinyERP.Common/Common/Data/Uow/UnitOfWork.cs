namespace TinyERP.Common.Common.Data.Uow
{
    public class UnitOfWork : IUnitOfWork
    {
        public IDbContext Context { get; private set; }
        public UnitOfWork(IDbContext dbContext)
        {
            this.Context = dbContext;
        }
        public void Commit()
        {
            this.Context.SaveChanges();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}
