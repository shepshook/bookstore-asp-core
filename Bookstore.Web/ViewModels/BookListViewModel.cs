using System.Collections.Generic;
using Bookstore.Core.Entities;

namespace Bookstore.Web.ViewModels
{
    public class BookListViewModel
    {
        public IEnumerable<Book> Books { get; set; }
        public IEnumerable<Publisher> Publishers { get; set; }
        public string CurrentPublisher { get; set; }
    }
}