namespace REST.Service
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using REST.Context;
    using REST.Entity;
    public class UserService
    {
        internal IList<User> GetUsers()
        {
            RESTDbContext context = new RESTDbContext();
            return context.Users.ToList();
        }

        internal User GetUser(int userId)
        {
            RESTDbContext context = new RESTDbContext();
            return context.Users.FirstOrDefault(item => item.Id == userId);
        }

        internal User CreateUser(CreateUserRequest request)
        {

            RESTDbContext context = new RESTDbContext();
            User user = new User() {
                FirstName=request.FirstName,
                LastName=request.LastName,
                UserName=request.UserName
            };
            context.Users.Add(user);
            context.SaveChanges();

            return this.GetUser(user.Id);
        }

        internal void UpdateUser(UpateUserRequest request)
        {
            RESTDbContext context = new RESTDbContext();
            User user = context.Users.FirstOrDefault(item => item.Id==request.UserId);
            user.FirstName = request.FirstName;
            user.LastName = request.LastName;
            user.UserName = request.UserName;
            context.SaveChanges();
        }
    }
}