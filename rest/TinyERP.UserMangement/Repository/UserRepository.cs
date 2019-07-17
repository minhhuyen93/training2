using System.Collections.Generic;
using System.Linq;
using TinyERP.Common.Common.Data;
using TinyERP.Common.Common.Data.Uow;
using TinyERP.UserMangement.Aggregate;

namespace TinyERP.UserMangement.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository() : base() { }
        public UserRepository(IUnitOfWork uow) : base(uow.Context) { }
        public User GetById(int userId)
        {
            return this.DbSet.AsQueryable().FirstOrDefault(x => x.Id == userId);
        }

        public IList<User> GetUsers()
        {
            return this.DbSet.AsQueryable().ToList();
        }
    }
}
