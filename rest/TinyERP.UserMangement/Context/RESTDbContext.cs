namespace TinyERP.UserMangement.Context
{
    using System.Data.Entity;
    using TinyERP.UserMangement.Aggregate;
    public class RESTDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserGroup> UserGroups { get; set; }
        public RESTDbContext() : base("RESTDbContext")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<RESTDbContext>());
        }
    }
}