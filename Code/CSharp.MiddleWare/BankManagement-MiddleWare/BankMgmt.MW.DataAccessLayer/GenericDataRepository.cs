using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Data.Entity;

namespace BankMgmt.MW.DataAccessLayer
{
    public class GenericDataRepository<T> : IGenericDataRepository<T> where T:class
    {
        public IList<T> GetAll(params Expression<Func<T, object>>[] navigationProperties)
        {
            List<T> list = null;
            using (var context = new BankManagementEntities())
            {
                context.Configuration.ProxyCreationEnabled = false;
                IQueryable<T> dbquery = context.Set<T>();
                
                foreach (Expression<Func<T, object>> navigationProperty in navigationProperties)
                {
                    dbquery = dbquery.Include<T, object>(navigationProperty);
                }
                list = dbquery.AsNoTracking().ToList<T>();
            }
            return list;
        }

        public IList<T> GetList(Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties)
        {
            List<T> list = null;
            using (var context = new BankManagementEntities())
            {
                IQueryable<T> dbquery = context.Set<T>();

                foreach (Expression<Func<T, object>> navigationProperty in navigationProperties)
                {
                    dbquery = dbquery.Include<T, object>(navigationProperty);
                }
                list = dbquery.AsNoTracking().Where<T>(where).ToList<T>();
            }
            return list;
        }

        public T GetSingle(Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties)
        {
            using (var context = new BankManagementEntities())
            {
                IQueryable<T> dbquery = context.Set<T>();

                foreach (Expression<Func<T, object>> navigationProperty in navigationProperties)
                {
                    dbquery = dbquery.Include<T, object>(navigationProperty);
                }
                return dbquery.AsNoTracking().Where<T>(where).SingleOrDefault<T>();
            }
        }

        public void Add(params T[] items)
        {
            using (var context = new BankManagementEntities())
            {
                foreach (T item in items)
                {
                    context.Entry(item).State = System.Data.Entity.EntityState.Added;
                }
                context.SaveChanges();
            }
        }

        public void Update(params T[] items)
        {
            using (var context = new BankManagementEntities())
            {
                foreach (T item in items)
                {
                    context.Entry(item).State = System.Data.Entity.EntityState.Modified;
                }
                context.SaveChanges();
            }
        }

        public void Remove(params T[] items)
        {
            using (var context = new BankManagementEntities())
            {
                foreach (T item in items)
                {
                    context.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                }
                context.SaveChanges();
            }
        }
    }
}
