using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Web.Routing;
using Microsoft.Practices.Unity;
using System.Diagnostics.Contracts;

namespace Tumsun.Saigon.Web.Mvc
{
    public class UnityControllerFactory : DefaultControllerFactory, IControllerActivator
    {
        private readonly IUnityContainer container;

        public UnityControllerFactory(IUnityContainer container)
        {
            Contract.Requires<ArgumentNullException>( container != null, "container");

            this.container = container;
        }

        public IController Create(RequestContext requestContext, Type controllerType)
        {
            Contract.Requires<ArgumentNullException>(requestContext != null, "requestContext");
            Contract.Requires<ArgumentNullException>(controllerType != null, "controllerType");

            return container.Resolve(controllerType) as IController;
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            Contract.Requires<ArgumentNullException>(requestContext != null, "requestContext");
            Contract.Requires<ArgumentNullException>(controllerType != null, "controllerType");

            return container.Resolve(controllerType) as IController;
        }
    }
}
