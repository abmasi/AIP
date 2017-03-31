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
    public class NewsRepository : RepositoryBase<News>, INewsRepository
    {
        public NewsRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }

        public void Delete(string Id)
        {
            throw new NotImplementedException();
        }

        public bool Exists(Expression<Func<News, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<News> GetTopNews()
        {
            return base.GetAll().OrderByDescending(x => x.PostedOn).Take(5);
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
