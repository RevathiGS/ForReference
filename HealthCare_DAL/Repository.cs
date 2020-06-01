using System;
using System.Linq;
using System.Linq.Expressions;
using System.Data;
using Models;
using System.Data.Entity;

namespace HealthCare_DAL
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        private Entities dataContext;
        private readonly IDbSet<T> dbset;
        protected Repository(IDatabaseFactory databaseFactory)
        {
            DatabaseFactory = databaseFactory;
            dbset = DataContext.Set<T>();
        }

        protected IDatabaseFactory DatabaseFactory
        {
            get;
            private set;
        }

        protected Entities DataContext
        {
            get { return dataContext ?? (dataContext = DatabaseFactory.Get()); }
        }
        
        public virtual T GetById(string id)
        {
            return dbset.Find(id);
        }
        
        public T Get(Expression<Func<T, bool>> where)
        {
            return dbset.Where(where).FirstOrDefault<T>();
        }

        //public T SingleOrDefault(Expression<Func<T, bool>> predicate)
        //{
        //    return dbset.IDbSet<T>().SingleOrDefault(predicate);
        //}

    }

    public interface IRepository<T> where T : class
    {
        T GetById(string Id);
    }
}
