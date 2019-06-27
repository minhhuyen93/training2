using TinyERP.Common.Common.IoC;
using TinyERP.Common.Common.Task;

namespace TinyERP.UserManagement.Share.Facade
{
    public class Bootstrapper : IBootStrapper
    {
        public void Execute()
        {
            IoC.RegisterAsSingleton<IUserManagementFacade, RemoteUserManagementFacade>();
        }
    }
}
