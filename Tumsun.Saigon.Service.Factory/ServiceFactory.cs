using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tumsun.Saigon.Service.Interfaces;
using Tumsun.Saigon.Service.BasicServices;

namespace Tumsun.Saigon.Service.Factory
{
    public class ServiceFactory
    {
        private static ServiceFactory _factory;

        private ServiceFactory()
        {
        
        }

        static ServiceFactory()
        {
            _factory = new ServiceFactory();
        }

        public static ServiceFactory DefaultFactory() {
            return _factory;
        }

        public ICatalogVehicleServices GetCatalogVehicleServices() { 
            return new CatalogVehicleServices(); 
        }
    }
}
