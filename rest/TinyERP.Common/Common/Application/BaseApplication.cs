using System;
using System.Collections.Generic;
using TinyERP.Common.Common.Helper;
using TinyERP.Common.Common.Task;
using TinyERP.Common.Tasks;

namespace TinyERP.Common.Common.Application
{
    public abstract class BaseApplication : IApplication
    {
        public ApplicationType Type { get; private set; }
        public BaseApplication(ApplicationType type)
        {
            this.Type = type;
        }
        public virtual void OnApplicationEnding()
        {
            AssemblyHelper.Execute<IApplicationEnd>();
        }

        public virtual void OnApplicationStarting()
        {
            AssemblyHelper.Execute<IApplicationStarted>();
            AssemblyHelper.Execute<IBootStrapper>();
        }

        public void OnApplicationErrors(IList<Exception> errors)
        {
            ITaskArgument arg = this.GetTaskArgument();
            arg.Data = errors;
            AssemblyHelper.Execute<IApplicationError>(arg);
        }
        private ITaskArgument GetTaskArgument()
        {
            ITaskArgument arg = new TaskArgument();
            arg.Application = this;
            return arg;
        }
    }
}
