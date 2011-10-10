using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tumsun.Saigon.Domain.Model;
using Tumsun.Saigon.Domain.Services;
using Tumsun.Saigon.Presentation.WebMVC3.WorkerServices;
using System.Diagnostics.Contracts;

namespace Tumsun.Saigon.Presentation.WebMVC3.Controllers
{
    public class CatalogVehicleController : Controller
    {

        public ICatalogVehicleControllerWorkerServices WorkerService { get; private set; }

        public CatalogVehicleController(ICatalogVehicleControllerWorkerServices svc)
        {
            Contract.Requires<ArgumentNullException>(svc != null, "svc");

            this.WorkerService = svc;
        }

        //
        // GET: /CatalogVehicle/

        public ActionResult Index()
        {
            //ListAllVehiclesRequest request = new ListAllVehiclesRequest();
            //ListAllVehiclesResponse response = svc.ListAllVehicles(request);

            var model = this.WorkerService.GetListPageViewModel();

            return View(model);
        }


        public ActionResult Configure(int id) {
            return View();
        }
    }
}
