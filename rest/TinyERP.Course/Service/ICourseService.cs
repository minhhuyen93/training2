using System.Collections.Generic;

namespace TinyERP.Course.Service
{
    public interface ICourseService
    {
        IList<Entity.Course> GetCourses();
    }
}
