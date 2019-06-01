namespace REST.Task
{
    using REST.Common.IoC;
    using REST.Common.Task;
    using REST.Service;
    public class BootStrapper : IBootStrapper
    {
        public void Execute()
        {
            IoC.RegisterAsSingleton<IUserService, UserService>();
        }
    }
}