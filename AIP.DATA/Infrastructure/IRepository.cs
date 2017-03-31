using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AIP.DATA.Infrastructure
{
    public interface IRepository<T, Key> where T : AIP.Model.IEntity<Key>
    {
        void Add(T entity);

        void Update(T entity);

        void Delete(string Id);

        void Delete(Expression<Func<T, bool>> where);

        T GetById(string id);
        
        T Get(Expression<Func<T, bool>> where);
        
        IEnumerable<T> GetAll();
        
        IEnumerable<T> GetMany(Expression<Func<T, bool>> where);

        bool Exists(Expression<Func<T, bool>> predicate);

        IDisposable RequestStart();

        void RequestDone();
    }

    public interface IRepository<T> where T : Model.IEntity<string>
    {
        void Add(T entity);

        void Update(T entity);

        void Delete(string Id);

        void Delete(Expression<Func<T, bool>> where);

        T GetById(string id);

        T Get(Expression<Func<T, bool>> where);

        IEnumerable<T> GetAll();

        IEnumerable<T> GetMany(Expression<Func<T, bool>> where);

        bool Exists(Expression<Func<T, bool>> predicate);

        IDisposable RequestStart();

        void RequestDone();
    }


}
