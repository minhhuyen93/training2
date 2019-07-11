namespace TinyERP.UserMangement.Context
{
    using System.Data.Entity;
    using TinyERP.UserMangement.Aggregate;
    public class RESTDbContext : DbContext, IUserManagementDbContext
    {
        public RESTDbContext() : base(TinyERP.Common.Config.Configuration.Instance.UserManagementDbContext.Name)
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<RESTDbContext>());
        }
        public IDbSet<User> Users { get; set; }
        public IDbSet<UserGroup> UserGroups { get; set; }
    }
}