namespace REST.Controllers
{
    using REST.Common;
    using REST.Entity;
    using REST.Service;
    using System.Collections.Generic;
    using System.Web.Http;
    [RoutePrefix("api/users")]
    public class UsersController: ApiController
    {
        [HttpGet()]
        [Route("")]
        public IList<User> GetUsers() {
            UserService userService = new UserService();
            return userService.GetUsers();
            //IPaging<User> paging = new Paging<User>();
            //UserService userService = new UserService();
            //paging.SetData(userService.GetUsers());
            //paging.SetTotalPage(10);
            //paging.SetPageIndex(5);
            //return paging;
        }
        [HttpGet()]
        [Route("{userId}")]
        public User GetUser(int userId)
        {
            UserService userService = new UserService();
            return userService.GetUser(userId);
        }

        [HttpPost()]
        [Route("")]
        public User CreateUser(CreateUserRequest request)
        {
            UserService userService = new UserService();
            return userService.CreateUser(request);
        }

        [HttpPut()]
        [Route("{userId}")]
        public void UpdateUser(int userId, UpateUserRequest request)
        {
            request.UserId = userId;
            UserService userService = new UserService();
            userService.UpdateUser(request);
        }
    }
}
