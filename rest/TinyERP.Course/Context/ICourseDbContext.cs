using System.Data.Entity;

namespace TinyERP.Course.Context
{
    public interface ICourseDbContext
    {
        IDbSet<Entity.Course> Courses { get; }
        int SaveChanges();
    }
}
