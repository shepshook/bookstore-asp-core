using Bookstore.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Bookstore.Infrastructure.Repositories
{
    internal abstract class Repository<TEntity> where TEntity : Entity
    {
        protected readonly BookstoreContext Context;
        protected readonly DbSet<TEntity> DbSet;

        protected Repository(BookstoreContext context)
        {
            Context = context;
            DbSet = Context.Set<TEntity>();
        }
    }
}