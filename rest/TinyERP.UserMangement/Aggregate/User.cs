namespace TinyERP.UserMangement.Aggregate
{
    using TinyERP.Common.Common.Attribute;
    using TinyERP.UserMangement.Context;
    using TinyERP.UserMangement.Share;
    [DbContextAttribute(Use=typeof(IUserManagementDbContext))]
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public UserStatus Status { get; set; }
    }
}