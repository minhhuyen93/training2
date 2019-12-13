namespace TinyERP.Common.Tasks
{
    using TinyERP.Common.Common.Task;
    using TinyERP.Common.Config;
    public class BaseTask : IBaseTask
    {
        public int Priority { get; private set; }
        public ApplicationType AppType { get; set; }
        public BaseTask(ApplicationType appType = ApplicationType.All, TaskPriority priority = TaskPriority.Normal)
        {
            this.Priority = (int)priority;
            this.AppType = appType;
        }

        protected bool Enable
        {
            get
            {
                ApplicationTaskElement config = Configuration.Instance.ApplicationTasks[this.GetType().FullName];
                TaskRunningMode runningMode = Configuration.Instance.ApplicationTasks.Mode;
                return config != null ? config.Enable : runningMode == TaskRunningMode.AllowAll;
            }
        }
        public void Execute(ITaskArgument arg)
        {
            if (!this.Enable) { return; }
            this.ExecuteInternal(arg);
        }
        protected virtual void ExecuteInternal(ITaskArgument arg) { }
    }
}
