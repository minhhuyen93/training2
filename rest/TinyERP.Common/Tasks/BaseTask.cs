namespace TinyERP.Common.Tasks
{
    using TinyERP.Common.Common.Task;
    using TinyERP.Common.Config;
    public class BaseTask : IBaseTask
    {
        protected bool Enable
        {
            get
            {
                ApplicationTaskElement config = Configuration.Instance.ApplicationTasks[this.GetType().FullName];
                TaskRunningMode runningMode = Configuration.Instance.ApplicationTasks.Mode;
                return config != null ? config.Enable : runningMode == TaskRunningMode.AllowAll;
            }
        }
        public void Execute()
        {
            if (!this.Enable) { return; }
            this.ExecuteInternal();
        }
        protected virtual void ExecuteInternal() { }
    }
}
