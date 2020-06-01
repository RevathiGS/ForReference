using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace HealthCare_DAL
{
    class UnitOfWork: IUnitOfWork
    {
        private readonly IDatabaseFactory databaseFactory;
        private Entities dataContext;

        public UnitOfWork(IDatabaseFactory databaseFactory)
        {
            this.databaseFactory = databaseFactory;
        }

        protected Entities DataContext
        {
            get { return dataContext ?? (dataContext = databaseFactory.Get()); }
        }

        public void Commit()
        {
            //Committing code implementation todo
            //I will try to get some generic code instead of calling context.Save changes here only
            //Lets not add the Context class responsibility here. Lets think on this and implement.
            //dataContext.SaveChanges();
        }
    }

    public interface IUnitOfWork
    {
        void Commit();
    }
}
