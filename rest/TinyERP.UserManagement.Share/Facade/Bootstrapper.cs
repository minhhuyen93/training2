using System.Configuration;
using TinyERP.Common.Common.IoC;
using TinyERP.Common.Common.Task;

namespace TinyERP.UserManagement.Share.Facade
{
    public class Bootstrapper : IBootStrapper
    {
        public void Execute()
        {
            var remote = TinyERP.Common.Config.Configuration.Instance.UserManagement.IntegrationMode;
            if (remote == Common.IntegrationModeType.Remote)
            {
                IoC.RegisterAsSingleton<IUserManagementFacade, RemoteUserManagementFacade>();
            }
        }
    }
}
