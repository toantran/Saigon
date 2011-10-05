using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tumsun.Saigon.Service.Interfaces;
using Tumsun.Saigon.Service.Interfaces.DTO;
using Tumsun.Saigon.Domain.DomainObject.Repository;

namespace Tumsun.Saigon.Service.BasicServices
{
    public class CatalogVehicleServices : ICatalogVehicleServices
    {
        #region ICatalogVehicleServices Members

        public ListAllVehiclesResponse ListAllVehicles(ListAllVehiclesRequest request)
        {
            ICatalogVehicleRepository vehicleRepo = RepositoryFactory.DefaultFactory()
                .GetCatalogVehicleRepository();

            ListAllVehiclesResponse response = new ListAllVehiclesResponse { 
                 CatalogVehicles = vehicleRepo.List()
            };

            return response;
        }

        #endregion
    }
}
