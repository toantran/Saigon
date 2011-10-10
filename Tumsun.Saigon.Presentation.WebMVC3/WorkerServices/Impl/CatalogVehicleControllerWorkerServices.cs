using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tumsun.Saigon.Domain.Services;
using Tumsun.Saigon.Domain.Repositories;
using System.Diagnostics.Contracts;
using Tumsun.Saigon.Presentation.WebMVC3.Models.CatalogVehicle;

namespace Tumsun.Saigon.Presentation.WebMVC3.WorkerServices.Impl
{
    public class CatalogVehicleControllerWorkerServices : ICatalogVehicleControllerWorkerServices
    {
        public ICatalogVehicleServices CatalogVehicleService { get; private set; }
        public ICatalogVehicleRepository CatalogVehicleRepo { get; private set; }

        public CatalogVehicleControllerWorkerServices(ICatalogVehicleServices svc, ICatalogVehicleRepository repo)
        {
            Contract.Requires<ArgumentNullException>(svc != null, "svc");
            Contract.Requires<ArgumentNullException>(repo != null, "repo");

            this.CatalogVehicleRepo = repo;
            this.CatalogVehicleService = svc;
        }

        public ListViewModel GetListPageViewModel()
        {
            ListViewModel model = new ListViewModel();

            model.Vehicles = this.CatalogVehicleRepo
                                .Select(e => new ListViewModel.VehicleIndo
                                {
                                    Id = e.Id,
                                    Name = e.Name,
                                    Price = e.CatalogPrice
                                });

            return model;
        }

        public CatalogVehicleViewModel GetVehicleViewModelById(int vehicleId)
        {
            CatalogVehicleViewModel model = new CatalogVehicleViewModel();

            return model;
        }
    }
}