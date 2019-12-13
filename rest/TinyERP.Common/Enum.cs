namespace TinyERP.Common
{
    public enum IntegrationModeType
    {
        Remote = 1,
        InApp = 2
    }

    public enum IOMode
    {
        ReadOnly = 1,
        Write = 2
    }
    public enum ApplicationType
    {
        All =0,
        WebApi = 1
    }
    public enum TaskRunningMode
    {
        AllowAll = 1,
        DenyAll = 2
    }
    public enum TaskPriority {
        Normal =50,
        High = 70
    }
}
