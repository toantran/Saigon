using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tumsun.Saigon.Domain.DomainObject.DOM;

namespace Tumsun.Saigon.Service.Interfaces.DTO
{
    public class GetOptionsResponse
    {
        public IEnumerable<CatalogOption> CatalogOptions { get; set; }
    }
}
