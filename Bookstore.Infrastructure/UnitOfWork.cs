using System;
using Bookstore.Core.Repositories;
using Bookstore.Infrastructure.Repositories;

namespace Bookstore.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private BookstoreContext _context;
        private IAuthorRepository _authorRepository;
        private IBookRepository _bookRepository;
        private IPublisherRepository _publisherRepository;

        private BookstoreContext Context => _context ??= new BookstoreContext();

        public IAuthorRepository AuthorRepository => _authorRepository ??= new AuthorRepository(Context);
        public IBookRepository BookRepository => _bookRepository ??= new BookRepository(Context);
        public IPublisherRepository PublisherRepository => _publisherRepository ??= new PublisherRepository(Context);

        public void Commit()
        {
            if (_isDisposed)
                throw new ObjectDisposedException("UnitOfWork");

            Context.SaveChanges();
        }

        private bool _isDisposed;

        public void Dispose()
        {
            if (_context == null)
                return;
            
            if (!_isDisposed)
                Context.Dispose();

            _isDisposed = true;
        }
    }
}