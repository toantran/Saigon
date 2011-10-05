using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tumsun.Saigon.Domain.DomainObject.Repository;
using Tumsun.Saigon.Data.OracleEF;

namespace Tumsun.Saigon.Service.BasicServices
{
    class RepositoryFactory
    {
        private static RepositoryFactory _factory;

        private RepositoryFactory()
        {

        }

        static RepositoryFactory() {
            _factory = new RepositoryFactory();
        }

        public static RepositoryFactory DefaultFactory() { return _factory; }

        public ICatalogVehicleRepository GetCatalogVehicleRepository() {
            return new CatalogVehicleRepository();
        }
    }
}
