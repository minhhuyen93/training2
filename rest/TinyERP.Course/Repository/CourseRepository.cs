namespace TinyERP.Course.Repository
{
    using System.Collections.Generic;
    using System.Linq;
    using TinyERP.Common.Common.Data;
    using TinyERP.Common.Common.Data.Uow;
    public class CourseRepository : BaseRepository<Entity.Course>, ICourseRepository
    {
        public CourseRepository() : base()
        {
        }
        public CourseRepository(IUnitOfWork uow) : base(uow.Context)
        {
        }
        public IList<Entity.Course> GetCourses()
        {
            return this.DbSet.AsQueryable().ToList();
        }
    }
}
