using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tumsun.Saigon.Domain.Model
{
    public class VehicleModel : IAggregateRoot
    {
        public virtual int Id { get; set; }
        public virtual string ModelName { get; set; }
        public virtual DateTime EffectiveFrom { get; set; }
        public virtual DateTime EffectiveTo { get; set; }

        bool IAggregateRoot.CanBeSaved
        {
            get { throw new NotImplementedException(); }
        }

        bool IAggregateRoot.CanBeDeleted
        {
            get { throw new NotImplementedException(); }
        }
    }
}
