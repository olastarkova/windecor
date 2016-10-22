using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject;
using System.Web.Mvc;
using System.Web.Routing;
using application.Domain.Abstract;
using application.Domain.Enitites;
using Moq;
using application.Domain.Concrete;

namespace application.WebUI.Infastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;

        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)ninjectKernel.Get(controllerType);
        }
        private void AddBindings()
        {

         
            ninjectKernel.Bind<IroshtoryReopository>().To<EFProductRepository>();
            //Добавление привязок
        }
    }
}