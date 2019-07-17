namespace TinyERP.UserMangement.Service
{
    using System.Collections.Generic;
    using System.Linq;
    using TinyERP.Common.Common.Data.Uow;
    using TinyERP.Common.Common.IoC;
    using TinyERP.Common.Common.Validation;
    using TinyERP.Common.Services;
    using TinyERP.UserManagement.Share.Dto;
    using TinyERP.UserMangement.Aggregate;
    using TinyERP.UserMangement.Context;
    using TinyERP.UserMangement.Repository;

    public class UserService : BaseService, IUserService
    {
        public IList<User> GetUsers()
        {
            IUserRepository userRepo = IoC.Resolve<IUserRepository>();
            return userRepo.GetUsers();
        }

        public User GetUser(int userId)
        {
            IUserRepository userRepo = IoC.Resolve<IUserRepository>();
            return userRepo.GetById(userId);
        }

        public User CreateUser(CreateUserRequest request)
        {
            using (IUnitOfWork uow = this.CreateUnitOfWork<User>())
            {
                IUserRepository repo = IoC.Resolve<IUserRepository>(uow);
                User user = new User()
                {
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    UserName = request.UserName
                };
                repo.Add(user);
                uow.Commit();

                return this.GetUser(user.Id);
            }
        }

        private void Validate(CreateUserRequest request)
        {
            ValidationException validator = ValidationHelper.Validate(request, "common.invalid.request");
            if (request.UserName == "abc")
            {
                validator.Add(new ValidationError("addNewUser.userNameWasUsed", "user_name", request.UserName));
            }
            validator.ThrowIfError(); ;
        }
        public void UpdateUser(UpateUserRequest request)
        {
            RESTDbContext context = new RESTDbContext();
            User user = context.Users.FirstOrDefault(item => item.Id == request.UserId);
            user.FirstName = request.FirstName;
            user.LastName = request.LastName;
            user.UserName = request.UserName;
            context.SaveChanges();
        }

        public User GetUserByUserName(string userName)
        {
            RESTDbContext context = new RESTDbContext();
            User user = context.Users.FirstOrDefault(item => item.UserName.ToLower() == userName.ToLower());
            return user;
        }
    }
}