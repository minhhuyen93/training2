using TinyERP.Common.Common.Data.Uow;

namespace TinyERP.Common.Services
{
    public class BaseService
    {
        public IUnitOfWork CreateUnitOfWork<TEntity>()
        {
            return UnitOfWorkFactory.CreateContext<TEntity>();
        }
    }
}
