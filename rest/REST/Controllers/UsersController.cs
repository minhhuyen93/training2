﻿namespace REST.Controllers
{
    using REST.Common;
    using REST.Common.Attribute;
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
        [ResponseWrapper()]
        public IList<User> GetUsers()
        {
            UserService userService = new UserService();
            return userService.GetUsers();
        }
        [HttpGet()]
        [Route("{userId}")]
        [ResponseWrapper()]
        public User GetUser(int userId)
        {
            UserService userService = new UserService();
            return userService.GetUser(userId);
        }

        [HttpPost()]
        [Route("")]
        [ResponseWrapper()]
        public User CreateUser(CreateUserRequest request)
        {
                UserService userService = new UserService();
                return userService.CreateUser(request);
        }
    }
}
