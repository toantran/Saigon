using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tumsun.Saigon.Web.Mvc;

namespace Tumsun.Saigon.Presentation.WebMVC3.Models.CatalogVehicle
{
    public class ListViewModel: HtmlPageViewModel
    {
        public IEnumerable<VehicleIndo> Vehicles { get; set; }

        public class VehicleIndo {
            public int Id { get; set; }
            public string Name { get; set; }
            public double Price { get; set; }
        }
    }
}