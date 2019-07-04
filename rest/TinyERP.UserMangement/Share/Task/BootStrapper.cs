namespace TinyERP.UserMangement.Share.Task
{
    using TinyERP.Common.Common.IoC;
    using TinyERP.Common.Common.Task;
    using TinyERP.UserManagement.Share.Facade;
    using TinyERP.UserMangement.Service;
    using TinyERP.UserMangement.Share.Facade;
    using System.Configuration;

    public class BootStrapper : IBootStrapper
    {
        public void Execute()
        {
            IoC.RegisterAsSingleton<IUserService, UserService>();
            Common.IntegrationModeType remote = TinyERP.Common.Config.Configuration.Instance.UserManagement.IntegrationMode;
            if (remote != Common.IntegrationModeType.Remote)
            {
                IoC.RegisterAsSingleton<IUserManagementFacade, UserManagementFacade>();
            }
        }
    }
}