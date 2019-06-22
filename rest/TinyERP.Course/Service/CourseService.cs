namespace TinyERP.Course.Service
{
    using System.Collections.Generic;
    using System.Linq;
    using TinyERP.Course.Context;
    public class CourseService : ICourseService
    {
        public IList<Entity.Course> GetCourses()
        {
            CourseDbContext context = new CourseDbContext();
            return context.Courses.ToList();
        }
    }
}
