namespace REST.Common.IoC
{
    using REST.Common.IoC.Castle;
    public class IoC
    {
        static IBaseContainer container;
        static IoC()
        {
            IoC.container = new BaseContainer();
        }
        public static TResult Resolve<TResult>() where TResult : class
        {
            return IoC.container.Resolve<TResult>();
        }

        public static void RegisterAsSingleton<IInterface, Impl>()
            where Impl : IInterface where IInterface : class
        {
            IoC.container.RegisterAsSingleton<IInterface, Impl>();
        }
    }
}