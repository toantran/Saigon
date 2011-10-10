using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tumsun.Saigon.Domain.Model;

namespace Tumsun.Saigon.Domain.Services.DTO
{
    /// <summary>
    /// 
    /// </summary>
    public class SearchRequest : RequestDTO
    {
        public string VehicleMakeName { get; set; }
    }


    /// <summary>
    /// 
    /// </summary>
    public class SearchResponse : ResponseDTO
    {
        public IEnumerable<CatalogVehicle> Vehicles { get; set; }
    }
}
