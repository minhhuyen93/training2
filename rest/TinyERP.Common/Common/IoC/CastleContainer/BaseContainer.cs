
namespace TinyERP.Common.Common.IoC.CastleContainer
{
    using Castle.MicroKernel;
    using Castle.MicroKernel.Registration;
    using Castle.Windsor;
    using System;
    using System.Collections.Generic;
    using TinyERP.Common.Common.Helper;

    public class BaseContainer : IBaseContainer
    {
        IWindsorContainer container;
        public BaseContainer()
        {
            this.container = new WindsorContainer();
        }

        public void RegisterAsSingleton<IInterface, Impl>() where IInterface : class where Impl : IInterface
        {
            this.container.Register(Component.For<IInterface>().ImplementedBy<Impl>());
        }

        public TResult Resolve<TResult>(object[] args = null) where TResult : class
        {
            if (args == null || args.Length == 0)
            {
                return this.container.Resolve<TResult>();
            }
            Arguments arguments = new Arguments();
            for (int i = 0; i <= args.Length; i++)
            {
                if (args[i] == null) continue;
                IList<Type> types = AssemblyHelper.GetInterfaceInstance(args[i]);
                foreach (Type item in types)
                {
                    arguments.AddTyped(item, args[i]);
                }
            }
            return this.container.Resolve<TResult>(arguments);
        }
    }
}