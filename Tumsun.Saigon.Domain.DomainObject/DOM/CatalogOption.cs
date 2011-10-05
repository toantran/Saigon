using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Tumsun.Saigon.Domain.DomainObject.DOM
{
    [DataContract]
    public class CatalogOption: DomainObject
    {
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public double Price { get; set; }
        [DataMember]
        public CatalogVehicle CatalogVehicle { get; set; }
    }
}
