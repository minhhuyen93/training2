﻿namespace TinyERP.Course.Share.Task
{
    using TinyERP.Common.Common.IoC;
    using TinyERP.Common.Common.Task;
    using TinyERP.Common.Tasks;
    using TinyERP.Course.Repository;
    using TinyERP.Course.Service;

    public class Bootstrap : BaseTask,IBootStrapper
    {
        protected override void ExecuteInternal(ITaskArgument arg)
        {
            IoC.RegisterAsTransient<ICourseService, CourseService>();
            IoC.RegisterAsTransient<ICourseRepository, CourseRepository>();
        }
    }
}
