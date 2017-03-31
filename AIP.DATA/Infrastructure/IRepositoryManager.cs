using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace AIP.DATA.Infrastructure
{
    public interface IRepositoryManager<T, TKey> where T : Model.IEntity<TKey>
    {
        bool Exists { get; }
        string Name { get; }
        void Drop();
        bool IsCapped();
        void DropIndex(string keyname);
        void DropIndexes();
        void EnsureIndex(string keyname);
        void EnsureIndexes(string keyname, bool descending, bool unique, bool sparse);
        void EnsureIndexes(IEnumerable<string> keynames);
        void EnsureIndexes(IEnumerable<string> keynames, bool descending, bool unique, bool spares);
        void EnsureIndexes(IMongoIndexKeys keys, IMongoIndexOptions options);
        bool IndexExists(string keyname);
        bool IndexExists(IEnumerable<string> keynames);
        void Reindex();
        ValidateCollectionResult Validate();
        CollectionStatsResult GetStats();
        GetIndexesResult GetIndexes();
    }

    public interface IRepositoryManager<T> : IRepositoryManager<T, string>
        where T : Model.IEntity<string>
    {

    }
}
