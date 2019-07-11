using System.Data.Entity;
using TinyERP.UserMangement.Aggregate;

namespace TinyERP.UserMangement.Context
{
    public interface IUserManagementDbContext
    {
        IDbSet<User> Users { get; }
        IDbSet<UserGroup> UserGroups { get; }
        int SaveChanges();
    }
}
