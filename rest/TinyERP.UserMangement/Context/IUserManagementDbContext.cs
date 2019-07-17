using System.Data.Entity;
using TinyERP.Common.Common.Data;
using TinyERP.UserMangement.Aggregate;

namespace TinyERP.UserMangement.Context
{
    public interface IUserManagementDbContext : IDbContext
    {
        IDbSet<User> Users { get; }
        IDbSet<UserGroup> UserGroups { get; }
        int SaveChanges();
    }
}
