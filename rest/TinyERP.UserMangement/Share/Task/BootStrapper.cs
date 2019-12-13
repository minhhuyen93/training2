namespace TinyERP.UserMangement.Share.Task
{
    using TinyERP.Common.Common.IoC;
    using TinyERP.Common.Common.Task;
    using TinyERP.UserManagement.Share.Facade;
    using TinyERP.UserMangement.Service;
    using TinyERP.UserMangement.Share.Facade;
    using TinyERP.UserMangement.Repository;
    using TinyERP.Common.Tasks;

    public class BootStrapper : BaseTask,IBootStrapper
    {
        protected override void ExecuteInternal(ITaskArgument arg)
        {
            IoC.RegisterAsTransient<IUserService, UserService>();
            IoC.RegisterAsTransient<IUserRepository, UserRepository>();
            Common.IntegrationModeType remote = TinyERP.Common.Config.Configuration.Instance.UserManagement.IntegrationMode;
            if (remote != Common.IntegrationModeType.Remote)
            {
                IoC.RegisterAsSingleton<IUserManagementFacade, UserManagementFacade>();
            }
        }
    }
}