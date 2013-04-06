using System;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;

namespace ThenComesMarriage.Ninject
{
    public class ControllerFactory : DefaultControllerFactory
    {
        private readonly IKernel kernel;

        public ControllerFactory(IKernel kernel)
        {
            this.kernel = kernel;
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)kernel.Get(controllerType);
        }
    }
}