namespace TinyERP.Course.Api
{
    using System.Collections.Generic;
    using System.Web.Http;
    using TinyERP.Common.Common.Attribute;
    using TinyERP.Common.Common.IoC;
    using TinyERP.Course.Service;
    [RoutePrefix("api/courses")]
    public class CoursesController : ApiController
    {
        [HttpGet()]
        [Route("")]
        [ResponseWrapper()]
        public IList<TinyERP.Course.Entity.Course> GetCourses()
        {
            ICourseService couresService = IoC.Resolve<ICourseService>();
            return couresService.GetCourses();
        }
    }
}
