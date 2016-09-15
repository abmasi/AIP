using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIP.DATA.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private AIPEntities dbContext;
        private readonly IDbFactory dbFactory;

        public UnitOfWork(IDbFactory DbFactory)
        {
            dbFactory = DbFactory;
        }

        public AIPEntities DbContext
        {
            get { return dbContext ?? (dbContext = new AIPEntities()); }
        }

        public void Commit()
        {
            DbContext.Commit();
        }
    }
}
