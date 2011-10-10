using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tumsun.Saigon.Domain.Model;
using Tumsun.Saigon.Domain.Repositories;
using System.Data.Entity;

namespace Tumsun.Saigon.Data.OracleEF.Repositories
{
    public class Repository<T> : IRepository<T> where T : class, IAggregateRoot
    {
        private SaigonContext _activeContext = null;


        public Repository()
        {
            _activeContext = new SaigonContext();
        }


        public Repository(SaigonContext activeContext)
        {
            _activeContext = activeContext;
        }


        public SaigonContext ActiveContext
        {
            get { return _activeContext; }
            private set { _activeContext = value; }
        }


        private DbSet<T> set = null;

        public DbSet<T> Set
        {
            get
            {
                if (set == null)
                {
                    set = this.ActiveContext.Set<T>();
                }
                return set;
            }
        }


        public IQueryable<T> Include(System.Linq.Expressions.Expression<Func<T, object>> subSelector)
        {
            return this.ActiveContext.Set<T>()
                .Include(subSelector);
        }

        public void Update(T item)
        {
            this.ActiveContext.SaveChanges();
        }

        public void Add(T item)
        {
            this.Set.Add(item);
            this.ActiveContext.SaveChanges();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            return this.Set.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { return this.Set.Count(); }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(T item)
        {
            try
            {
                this.Set.Remove(item);
                this.ActiveContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this.Set.AsEnumerable().GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public Type ElementType
        {
            get { return (this.Set.AsQueryable() as IQueryable).ElementType; }
        }

        public System.Linq.Expressions.Expression Expression
        {
            get { return (this.Set.AsQueryable() as IQueryable).Expression; }
        }

        public IQueryProvider Provider
        {
            get { return (this.Set.AsQueryable() as IQueryable).Provider; }
        }
    }
}
