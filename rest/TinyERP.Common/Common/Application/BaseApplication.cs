using TinyERP.Common.Common.Helper;
using TinyERP.Common.Common.Task;

namespace TinyERP.Common.Common.Application
{
    public abstract class BaseApplication
    {
        public virtual void OnApplicationEnding()
        {
            AssemblyHelper.Execute<IApplicationEnd>();
        }

        public virtual void OnApplicationStarting()
        {
            AssemblyHelper.Execute<IApplicationStarted>();
            AssemblyHelper.Execute<IBootStrapper>();
        }
    }
}
