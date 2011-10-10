using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using Microsoft.Practices.Unity;
using System.Configuration;
using Microsoft.Practices.Unity.Configuration;
using System.Web.Mvc;
using Tumsun.Saigon.Web.Mvc;

namespace Tumsun.Saigon.Web
{
    public class BaseHttpApplication : HttpApplication
    {
        static IUnityContainer container = new UnityContainer();

        static BaseHttpApplication() {
            UnityConfigurationSection section = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");

            section.Configure(container);

            // register extra class begin
            // register extra class end

            UnityControllerFactory factory = new UnityControllerFactory(container);
            ControllerBuilder.Current.SetControllerFactory(factory);
        }
    }
}
