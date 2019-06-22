using System.Data.Entity;

namespace TinyERP.Course.Context
{
    public class CourseDbContext : DbContext
    {
        public CourseDbContext() : base("CourseDbConnectionString")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<CourseDbContext>());
        }

        public DbSet<Entity.Course> Courses { get; set; }
    }
}
