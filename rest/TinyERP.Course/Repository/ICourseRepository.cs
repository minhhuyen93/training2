using System.Collections.Generic;
using TinyERP.Common.Common.Data;

namespace TinyERP.Course.Repository
{
    public interface ICourseRepository : IBaseRepository<Entity.Course>
    {
        IList<Entity.Course> GetCourses();
    }
}
