using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Tumsun.Saigon.Domain.DomainObject.DOM
{
    [DataContract]
    public class CatalogVehicle : DomainObject
    {
        [DataMember]
        public int ModelId { get; set; }
        [DataMember]
        public int MakeId { get; set; }
        [DataMember]
        public int ModelYear { get; set; }
        [DataMember]
        public double CatalogPrice { get; set; }
        [DataMember]
        public string Description { get; set; }

        public ICollection<CatalogOption> CatalogOptions { get; set; }
    }
}
