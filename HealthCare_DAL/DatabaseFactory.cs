using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace HealthCare_DAL
{
    public class DatabaseFactory : IDisposable, IDatabaseFactory
    {
        private Entities dataContext;

        public Entities Get()
        {
            return dataContext ?? (dataContext = new Entities());
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool isDisposable)
        {

        }
    }

    public interface IDatabaseFactory
    {
        Entities Get();
    }
}
