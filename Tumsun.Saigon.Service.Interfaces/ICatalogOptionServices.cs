using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tumsun.Saigon.Service.Interfaces
{
    public interface ICatalogOptionServices
    {
        DTO.GetOptionsResponse GetOptions(DTO.GetOptionRequest request);
    }
}
