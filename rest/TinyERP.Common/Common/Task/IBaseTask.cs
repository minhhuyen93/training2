namespace TinyERP.Common.Common.Task
{
    public interface IBaseTask
    {
        int Priority { get; }
        ApplicationType AppType { get; }
        void Execute(ITaskArgument arg);
    }
}