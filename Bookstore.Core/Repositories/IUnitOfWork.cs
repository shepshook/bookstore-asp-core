using System;

namespace Bookstore.Core.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IBookRepository BookRepository { get; }
        IAuthorRepository AuthorRepository { get; }
        IPublisherRepository PublisherRepository { get; }

        void Commit();
    }
}