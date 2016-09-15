using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
