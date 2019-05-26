namespace REST.Controllers
{
    using REST.Common;
    using REST.Common.Data;
    using REST.Common.Validation;
    using REST.Entity;
    using REST.Service;
    using System.Collections.Generic;
    using System.Web.Http;
    [RoutePrefix("api/users")]
    public class UsersController : ApiController
    {
        [HttpGet()]
        [Route("")]
        public ResponseData GetUsers()
        {
            ResponseData response = new ResponseData();
            UserService userService = new UserService();
            var users = userService.GetUsers();
            response.SetData(users);
            return response;
            //IPaging<User> paging = new Paging<User>();
            //UserService userService = new UserService();
            //paging.SetData(userService.GetUsers());
            //paging.SetTotalPage(10);
            //paging.SetPageIndex(5);
            //return paging;
        }
        [HttpGet()]
        [Route("{userId}")]
        public ResponseData GetUser(int userId)
        {
            ResponseData response = new ResponseData();
            UserService userService = new UserService();
            var user = userService.GetUser(userId);
            response.SetData(user);
            return response;
        }

        [HttpPost()]
        [Route("")]
        public ResponseData CreateUser(CreateUserRequest request)
        {
            ResponseData response = new ResponseData();
            try
            {
                UserService userService = new UserService();
                var user = userService.CreateUser(request);
                response.SetData(user);
            }
            catch (ValidationException ex)
            {
                response.SetErrors(ex.Errors);
            }
            return response;
        }
    }
}
