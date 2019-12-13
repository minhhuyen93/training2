using System.Configuration;
using TinyERP.Common.Common.IoC;
using TinyERP.Common.Common.Task;
using TinyERP.Common.Tasks;

namespace TinyERP.UserManagement.Share.Facade
{
    public class Bootstrapper : BaseTask, IBootStrapper
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
