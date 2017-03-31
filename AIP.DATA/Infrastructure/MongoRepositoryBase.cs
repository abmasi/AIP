using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Core;
using System.Data.Entity;
using MongoDB.Bson;
using MongoDB.Driver.Linq;
using AIP.Model;

namespace AIP.DATA.Infrastructure
{
    public abstract class MongoRepositoryBase<T, Key> : IMongoRepository<T, Key> where T : IEntity<Key>
    {
        private AIPMongoDbContext DbContext;
        //private readonly IDbSet<T> dbSet;
        private readonly MongoDatabase _database;
        private string _collectionName;

        public MongoRepositoryBase(string CollectionName)
        {
            DbContext = new AIPMongoDbContext();
            _database = DbContext.AIPDatabase;
            _collectionName = CollectionName;
        }

        public MongoCollection<T> Collection
        {
            get { return _database.GetCollection<T>(_collectionName); }
        }

        public virtual Type ElementType
        {
            get { return this.Collection.AsQueryable<T>().ElementType; }
        }

        public Expression Expression
        {
            get { return this.Collection.AsQueryable<T>().Expression; }
        }

        public IQueryProvider Provider
        {
            get { return this.Collection.AsQueryable<T>().Provider; } 
        }

        public void Add(T entity)
        {
            this.Collection.Insert<T>(entity);
        }

        public void Delete(Expression<Func<T, bool>> where)
        {
            foreach(T entity in this.Collection.AsQueryable<T>().Where(where))
            {
                this.Delete(entity);
            }
        }

        public virtual void Delete(string Id)
        {
            this.Collection.Remove(Query.EQ("_id", new ObjectId(Id as string)));  
        }

        public virtual void Delete(ObjectId Id)
        {
            this.Collection.Remove(Query.EQ("_id", Id));
        }

        public virtual void Delete(T Entity)
        {
            this.Delete(Entity.Id as string);
        }

        public bool Exists(Expression<Func<T, bool>> predicate)
        {
            return this.Collection.AsQueryable<T>().Any(predicate);
        }

        public T Get(Expression<Func<T, bool>> where)
        {
            return this.Collection.AsQueryable<T>().Where(where).First();
        }

        public IEnumerable<T> GetAll()
        {
            return this.Collection.FindAllAs<T>();
        }


        public virtual T GetById(string id)
        {
            return this.Collection.FindOneByIdAs<T>(new ObjectId(id as string));
        }

        public virtual T GetById(ObjectId Id)
        {
            return this.Collection.FindOneByIdAs<T>(Id);
        }

        public virtual IEnumerator<T> GetEnumerator()
        {
            return this.Collection.AsQueryable<T>().GetEnumerator();
        }

        public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> where)
        {
            throw new NotImplementedException();
        }

        public virtual void RequestDone()
        {
            this.Collection.Database.RequestDone();
        }

        public virtual IDisposable RequestStart()
        {
            return this.Collection.Database.RequestStart();
        }

        public virtual void Update(T entity)
        {
            this.Collection.Save<T>(entity);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.Collection.AsQueryable<T>().GetEnumerator();
        }
    }

    public class MongoRepositoryBase<T> : MongoRepositoryBase<T, string>, IRepository<T>
        where T : IEntity<string>
    {
        public MongoRepositoryBase(string CollectionName) : base(CollectionName)
        {
        }
    }
}
