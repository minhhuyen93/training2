using System.Collections.Generic;
using TinyERP.UserMangement.Aggregate;

namespace TinyERP.UserMangement.Repository
{
    public interface IUserRepository
    {
        IList<User> GetUsers();
        User GetById(int userId);
        void Add(User user);
    }
}
