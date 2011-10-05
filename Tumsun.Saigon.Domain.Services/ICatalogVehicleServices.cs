using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tumsun.Saigon.Domain.Model;
using Tumsun.Saigon.Domain.Services.DTO;

namespace Tumsun.Saigon.Domain.Services
{
    public interface ICatalogVehicleServices
    {
        SearchResponse Search(SearchRequest searchRequest);
    }
}
