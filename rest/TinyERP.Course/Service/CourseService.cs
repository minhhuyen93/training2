namespace TinyERP.Course.Service
{
    using System;
    using System.Collections.Generic;
    using TinyERP.Common.Common.Data.Uow;
    using TinyERP.Common.Common.IoC;
    using TinyERP.Course.Dto;
    using TinyERP.Course.Repository;
    using TinyERP.UserManagement.Share.Dto;
    using TinyERP.UserManagement.Share.Facade;

    public class CourseService : ICourseService
    {
        public IList<Entity.Course> GetCourses()
        {
            ICourseRepository repo = IoC.Resolve<ICourseRepository>();
            return repo.GetCourses();
        }

        public void CreateCourse(CreateCourseRequest request)
        {
            using (IUnitOfWork uow = this.CreateUnitOfWork<Entity.Course>()) {
                IUserManagementFacade facade = IoC.Resolve<IUserManagementFacade>();
                CreateUserRequest createUserRequest = new CreateUserRequest(request.Author.FirstName, request.Author.LastName, request.Author.UserName);
                int authorId = facade.CreateUserIfNotExisted(createUserRequest);
                ICourseRepository courseRepo = IoC.Resolve<ICourseRepository>(uow);
                Entity.Course courseEntity = new Entity.Course()
                {
                    Name = request.Name,
                    Description = request.Description,
                    AuthorId = authorId
                };
                courseRepo.Add(courseEntity);
                uow.Commit();
            }
        }

        private IUnitOfWork CreateUnitOfWork<T>()
        {
            throw new NotImplementedException();
        }
    }
}
