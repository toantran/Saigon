using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tumsun.Saigon.Domain.Repositories;
using System.Diagnostics.Contracts;

namespace Tumsun.Saigon.Domain.Services.Implementations
{
    public class CatalogVehicleServices : ICatalogVehicleServices
    {
        public ICatalogVehicleRepository CatalogVehicleRepository { get; private set; }


        public CatalogVehicleServices(ICatalogVehicleRepository repo)
        {
            Contract.Requires<ArgumentNullException>(repo != null, "repo");
            Contract.Ensures(this.CatalogVehicleRepository == repo, "repo");

            this.CatalogVehicleRepository = repo;
        }

        public DTO.SearchResponse Search(DTO.SearchRequest searchRequest)
        {
            return new DTO.SearchResponse { 
                  Vehicles = CatalogVehicleRepository.Select( e => e )
            };
        }
    }
}
