using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tumsun.Saigon.Domain.Model
{
    public class CatalogOption 
    {
        public virtual int Id { get; set; }
        public virtual string OtionCode { get; set; }
        public virtual string Description { get; set; }
        public virtual double Price { get; set; }        
    }
}
