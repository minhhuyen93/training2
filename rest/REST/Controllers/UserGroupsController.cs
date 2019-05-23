namespace REST.Controllers
{
    using REST.Entity;
    using REST.Service;
    using System.Collections.Generic;
    using System.Web.Http;

    [RoutePrefix("api/userGroups")]
    public class UserGroupsController: ApiController
    {
        [HttpGet()]
        [Route("")]
        public IList<UserGroup> GetUserGroups() {
            UserGroupService service = new UserGroupService();
            return service.GetUserGroups();
        } 
    }
}