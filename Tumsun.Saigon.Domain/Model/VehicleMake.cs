using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tumsun.Saigon.Domain.Model
{
    public class VehicleMake : IAggregateRoot
    {
        public virtual int Id { get; set; }
        public virtual string MakeName { get; set; }
        public virtual DateTime EffectiveFrom { get; set; }
        public virtual DateTime EffectiveTo { get; set; }

        bool IAggregateRoot.CanBeSaved
        {
            get { return true; }
        }

        bool IAggregateRoot.CanBeDeleted
        {
            get { return false; }
        }
    }
}
