using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AIP.DATA.Infrastructure;
using AIP.Model;

namespace AIP.DATA.Repositories
{
    public class ActivityRepository : RepositoryBase<Activity>, IRepository<Activity>
    {
        public ActivityRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public void Delete(string Id)
        {
            throw new NotImplementedException();
        }

        public bool Exists(Expression<Func<Activity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void RequestDone()
        {
            throw new NotImplementedException();
        }

        public IDisposable RequestStart()
        {
            throw new NotImplementedException();
        }
    }
}
