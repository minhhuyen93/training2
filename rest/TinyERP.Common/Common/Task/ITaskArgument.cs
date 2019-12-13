using TinyERP.Common.Common.Application;

namespace TinyERP.Common.Common.Task
{
    public interface ITaskArgument
    {
        IApplication Application { get; set; }
        dynamic Data { get; set; }
    }
}
