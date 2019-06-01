namespace TinyERP.UserMangement.Service
{
    using System.Collections.Generic;
    using TinyERP.UserMangement.Aggregate;

    public interface IUserService
    {
        IList<User> GetUsers();
        User GetUser(int userId);
        User CreateUser(CreateUserRequest request);
        void UpdateUser(UpateUserRequest request);
    }
}