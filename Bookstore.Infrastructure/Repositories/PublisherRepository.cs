using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Bookstore.Core.Entities;
using Bookstore.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Bookstore.Infrastructure.Repositories
{
    internal sealed class PublisherRepository : Repository<Publisher>, IPublisherRepository
    {
        public PublisherRepository(BookstoreContext context) : base(context)
        {
        }
        
        public Publisher Get(Guid key) => MakeInclusions().SingleOrDefault(p => p.Id == key);

        public IEnumerable<Publisher> All(Expression<Func<Publisher, bool>> predicate = null)
        {
            var query = MakeInclusions().AsQueryable();
            if (predicate != null)
                query = query.Where(predicate);

            return query.ToList();
        }

        public void Insert(Publisher entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            
            entity.Id = Guid.NewGuid();
            DbSet.Add(entity);
        }

        public void Update(Publisher entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            
            DbSet.Update(entity);
        }

        public void Delete(Guid key) => DbSet.Remove(DbSet.Find(key));

        private IQueryable<Publisher> MakeInclusions() => DbSet.Include(x => x.Books);
    }
}