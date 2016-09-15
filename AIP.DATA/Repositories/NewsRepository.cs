using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AIP.DATA.Infrastructure;
using AIP.Model;

namespace AIP.DATA.Repositories
{
    public class NewsRepository : RepositoryBase<News>, INewsRepository
    {
        public NewsRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<News> GetTopNews()
        {
            return base.GetAll().OrderByDescending(x => x.PostedOn).Take(5);
        }
    }
}
