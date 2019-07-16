using System;

namespace TinyERP.Common.Common.Data.Uow
{
    public class UnitOfWorkFactory
    {
        internal static IUnitOfWork CreateContext<TEntity>()
        {
            IDbContext dbContetx = DbContextFactory.CreateContext<TEntity>();
            return new UnitOfWork(dbContetx);
        }
    }
}
