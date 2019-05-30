﻿using Castle.MicroKernel.Registration;
using Castle.Windsor;

namespace REST.Common.IoC.Castle
{
    public class BaseContainer : IBaseContainer
    {
        private IWindsorContainer container;
        public BaseContainer()
        {
            this.container = new WindsorContainer();
        }
        public void RegisterAsSingleton<IInterface, Impl>()
            where IInterface : class
            where Impl : IInterface
        {
            this.container.Register(Component.For<IInterface>().ImplementedBy<Impl>());
        }

        public TResult Resolve<TResult>() where TResult : class
        {
            return this.container.Resolve<TResult>();
        }
    }
}