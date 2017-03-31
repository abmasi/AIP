using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace AIP.DATA.Infrastructure
{
    public class MongoRepositoryManager<T, TKey> : IRepositoryManager<T, TKey>
        where T : Model.IEntity<TKey>
    {

        private AIPMongoDbContext DbContext;
        //private readonly IDbSet<T> dbSet;
        private readonly MongoDatabase _database;
        private string _collectionName;

        public MongoRepositoryManager(string CollectionName)
        {
            DbContext = new AIPMongoDbContext();
            _database = DbContext.AIPDatabase;
            _collectionName = CollectionName;
        }

        public MongoCollection<T> Collection
        {
            get { return _database.GetCollection<T>(_collectionName); }
        }

        public bool Exists
        {
            get
            {
               return this.Collection.Exists();
            }
        }

        public string Name
        {
            get
            {
                return this._collectionName;
            }
        }

        public void Drop()
        {
            this.Collection.Drop();
        }

        public void DropIndex(string keyname)
        {
            this.Collection.DropIndex(keyname);
        }

        public void DropIndexes()
        {
            this.Collection.DropAllIndexes();
        }

        public void EnsureIndex(string keyname)
        {
            this.Collection.CreateIndex(keyname);
        }

        public void EnsureIndexes(IEnumerable<string> keynames)
        {
            foreach(string keyname in keynames)
            {
                this.EnsureIndex(keyname);
            }
        }

        public void EnsureIndexes(IMongoIndexKeys keys, IMongoIndexOptions options)
        {
            this.Collection.CreateIndex(keys, options);
        }

        public void EnsureIndexes(IEnumerable<string> keynames, bool descending, bool unique, bool spares)
        {
            foreach (string key in keynames)
            {
                this.EnsureIndexes(key, descending, unique, spares);
            }
        }

        public void EnsureIndexes(string keyname, bool descending, bool unique, bool sparse)
        {
            var ixk = new IndexKeysBuilder();
            if(descending)
            {
                ixk.Descending(new string[] { keyname });
            }
            else
            {
                ixk.Ascending(new string[] { keyname });
            }

            this.EnsureIndexes(ixk, new IndexOptionsBuilder().SetUnique(unique).SetSparse(sparse));

            //this.Collection.CreateIndex(keyname, )
        }

        public GetIndexesResult GetIndexes()
        {
            return this.Collection.GetIndexes();
        }

        public CollectionStatsResult GetStats()
        {
            return this.Collection.GetStats();
        }

        public bool IndexExists(IEnumerable<string> keynames)
        {
            return this.Collection.IndexExists(keynames.ToArray());
        }

        public bool IndexExists(string keyname)
        {
            return this.IndexExists(new string[] { keyname });
        }

        public bool IsCapped()
        {
            return this.Collection.IsCapped();
        }

        public void Reindex()
        {
            this.Collection.ReIndex();
        }

        public ValidateCollectionResult Validate()
        {
            return this.Collection.Validate();
        }
    }
}
