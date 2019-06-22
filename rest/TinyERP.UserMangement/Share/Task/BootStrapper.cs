namespace TinyERP.UserMangement.Share.Task
{
    using TinyERP.Common.Common.IoC;
    using TinyERP.Common.Common.Task;
    using TinyERP.UserManagement.Share.Facade;
    using TinyERP.UserMangement.Service;
    using TinyERP.UserMangement.Share.Facade;

    public class BootStrapper : IBootStrapper
    {
        public void Execute()
        {
            IoC.RegisterAsSingleton<IUserService, UserService>();
            IoC.RegisterAsSingleton<IUserManagementFacade, UserManagementFacade>();
        }
    }
}