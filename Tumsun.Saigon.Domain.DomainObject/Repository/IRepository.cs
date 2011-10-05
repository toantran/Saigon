using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tumsun.Saigon.Domain.DomainObject.Repository
{
    public interface IRepository<T> where T: DomainObject.DOM.DomainObject
    {
        IQueryable<T> List();
        IQueryable<T> Read(int Id);
    }
}
