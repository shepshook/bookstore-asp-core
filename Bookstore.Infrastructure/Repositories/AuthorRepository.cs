using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Bookstore.Core.Entities;
using Bookstore.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Bookstore.Infrastructure.Repositories
{
    internal sealed class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        public AuthorRepository(BookstoreContext context) : base(context)
        {
        }
        
        public Author Get(Guid key) => MakeInclusions().SingleOrDefault(a => a.Id == key);

        public IEnumerable<Author> All(Expression<Func<Author, bool>> predicate = null)
        {
            var query = MakeInclusions().AsQueryable();
            if (predicate != null)
                query = query.Where(predicate);
            
            return query.ToList();
        }

        public void Insert(Author entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            
            entity.Id = Guid.NewGuid();
            DbSet.Add(entity);
        }

        public void Update(Author entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            
            DbSet.Update(entity);
        }

        public void Delete(Guid key) => DbSet.Remove(DbSet.Find(key));

        private IQueryable<Author> MakeInclusions() => DbSet.Include(author => author.BookAuthors)
            .ThenInclude(bookAuthor => bookAuthor.Book);
    }
}