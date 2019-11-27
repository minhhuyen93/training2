
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

        public void RegisterAsSingleton<IInterface, Impl>() 
            where IInterface : class where Impl : IInterface
        {
            this.container.Register(Component.For<IInterface>()
                .ImplementedBy<Impl>().LifestyleSingleton());
        }

        public void RegisterAsTransient<IInterface, Impl>() 
            where IInterface : class where Impl : IInterface
        {
            this.container.Register(Component.For<IInterface>()
                .ImplementedBy<Impl>().LifestyleTransient());
        }

        public TResult Resolve<TResult>(object[] args = null) where TResult : class
        {
            if (args == null || args.Length == 0)
            {
                return this.container.Resolve<TResult>();
            }
            Arguments arguments = new Arguments();
            for (int index = 0; index < args.Length; index++)
            {
                if (args[index] == null) continue;
                IList<Type> types = AssemblyHelper.GetInterfaceInstance(args[index]);
                foreach (Type item in types)
                {
                    arguments.AddTyped(item, args[index]);
                }
            }
            return this.container.Resolve<TResult>(arguments);
        }
    }
}