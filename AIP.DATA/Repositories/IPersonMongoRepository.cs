using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AIP.Model;
using AIP.DATA.Infrastructure;

namespace AIP.DATA.Repositories
{
    public interface IPersonMongoRepository : IMongoRepository<Person, string>
    {

    }
}
