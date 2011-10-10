using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tumsun.Saigon.Domain.Model
{
    public class CatalogVehicle : IAggregateRoot
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual int ModelId { get; set; }
        public virtual int MakeId { get; set; }
        public virtual int ModelYear { get; set; }
        public virtual double CatalogPrice { get; set; }
        public virtual string Description { get; set; }

        //public virtual VehicleMake Make { get; set; }
        //public virtual VehicleModel Model { get; set; }

        bool IAggregateRoot.CanBeSaved
        {
            get { return true; }
        }

        bool IAggregateRoot.CanBeDeleted
        {
            get { return true; }
        }
    }
}
