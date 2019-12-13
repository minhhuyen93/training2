using TinyERP.Common.Common.Application;
using TinyERP.Common.Common.Task;

namespace TinyERP.Common.Tasks
{
    public class TaskArgument : ITaskArgument
    {
        public IApplication Application { get; set; }
        public dynamic Data { get; set; }
    }
}
