using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tumsun.Saigon.Presentation.WebMVC3.Controllers
{
    public class CatalogVehicleController : Controller
    {
        //
        // GET: /CatalogVehicle/

        public ActionResult Index()
        {
            ICatalogVehicleServices svc = ServiceFactory.DefaultFactory().GetCatalogVehicleServices();

            ListAllVehiclesRequest request = new ListAllVehiclesRequest();
            ListAllVehiclesResponse response = svc.ListAllVehicles(request);

            return View(response.CatalogVehicles);
        }


        public ActionResult Configure(int id) {
            return View();
        }
    }
}
