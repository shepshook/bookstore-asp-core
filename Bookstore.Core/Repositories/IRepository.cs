using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Bookstore.Core.Entities;

namespace Bookstore.Core.Repositories
{
    public interface IRepository<TEntity, in TKey> where TEntity :  Entity<TKey>
    { 
        TEntity Get(TKey key);
        IEnumerable<TEntity> All(Expression<Func<TEntity, bool>> predicate = null);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TKey key);
    }
}