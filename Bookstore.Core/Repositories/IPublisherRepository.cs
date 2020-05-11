using System;
using Bookstore.Core.Entities;

namespace Bookstore.Core.Repositories
{
    public interface IPublisherRepository : IRepository<Publisher, Guid>
    {
    }
}