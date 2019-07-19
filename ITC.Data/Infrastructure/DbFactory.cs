using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITC.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private ITCDbContext dbContext;

        public ITCDbContext Init()
        {
            return dbContext ?? (dbContext = new ITCDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
