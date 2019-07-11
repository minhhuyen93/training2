using System.Data.Entity;
using TinyERP.Common.Common.Data;

namespace TinyERP.Course.Context
{
    public interface ICourseDbContext : IDbContext
    {
        IDbSet<Entity.Course> Courses { get; }
    }
}
