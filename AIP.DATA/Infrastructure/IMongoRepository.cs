using MongoDB.Driver;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AIP.DATA.Infrastructure
{
    public interface IMongoRepository<T, Key> : IQueryable<T>, IRepository<T, Key>
        where T : AIP.Model.IEntity<Key>
    {
        MongoCollection<T> Collection { get; }
    }
}
