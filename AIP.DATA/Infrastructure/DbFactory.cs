using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIP.DATA.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        AIPEntities dbContext;

        public AIPEntities Init()
        {
            return dbContext ?? (dbContext = new AIPEntities());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
