using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tumsun.Saigon.Domain.Model;
using Tumsun.Saigon.Presentation.WebMVC3.Models.CatalogVehicle;

namespace Tumsun.Saigon.Presentation.WebMVC3.WorkerServices
{
    public interface ICatalogVehicleControllerWorkerServices
    {
        ListViewModel GetListPageViewModel();
        CatalogVehicleViewModel GetVehicleViewModelById(int vehicleId);

    }
}
