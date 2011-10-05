using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Tumsun.Saigon.Domain.DomainObject.DOM
{
    [DataContract]
    public abstract class DomainObject
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
    }
}
