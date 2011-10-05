using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tumsun.Saigon.Service.Interfaces
{
    public interface ICatalogVehicleServices
    {
        DTO.ListAllVehiclesResponse ListAllVehicles(DTO.ListAllVehiclesRequest request);
    }
}
