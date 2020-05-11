using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Bookstore.Core.Entities;
using Bookstore.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Bookstore.Infrastructure.Repositories
{
    internal sealed class BookRepository : Repository<Book>, IBookRepository
    {
        public BookRepository(BookstoreContext context) : base(context)
        {
        }
        
        public Book Get(Guid key) => MakeInclusions().SingleOrDefault(b => b.Id == key);

        public IEnumerable<Book> All(Expression<Func<Book, bool>> predicate = null)
        {
            var query = MakeInclusions().OrderBy(x => x.Title).AsQueryable();
            if (predicate != null)
                query = query.Where(predicate);

            return query.ToList();
        }
        
        public void Insert(Book entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            
            entity.Id = Guid.NewGuid();
            DbSet.Add(entity);
        }

        public void Update(Book entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            
            DbSet.Update(entity);
        }

        public void Delete(Guid key) => DbSet.Remove(DbSet.Find(key));

        private IQueryable<Book> MakeInclusions() =>
            DbSet.Include(book => book.Publisher)
                .Include(book => book.BookAuthors)
                .ThenInclude(bookAuthor => bookAuthor.Author);
    }
}