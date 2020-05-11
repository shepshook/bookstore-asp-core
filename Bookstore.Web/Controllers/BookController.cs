using System;
using System.Linq.Expressions;
using Bookstore.Core.Entities;
using Bookstore.Core.Repositories;
using Bookstore.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.Web.Controllers
{
    public class BookController : Controller
    {
        private readonly IUnitOfWork _uow;

        public BookController(IUnitOfWork uow) => _uow = uow;

        [Route("")]
        public IActionResult List(BookListViewModel model)
        {
            model.Publishers = _uow.PublisherRepository.All();

            Expression<Func<Book, bool>> filter = null;
            if (Guid.TryParse(model.CurrentPublisher, out var currentPublisher))
                filter = x => x.PublisherId == currentPublisher;
            else if (model.CurrentPublisher == "None")
                filter = x => x.PublisherId == null;

            model.Books = _uow.BookRepository.All(filter);
            return View(model);
        }

        [Route("[controller]/[action]/{id:guid}")]
        public IActionResult Details(Guid id)
        {
            var book = _uow.BookRepository.Get(id);
            return book == null ? (IActionResult) NotFound() : View(book);
        }
    }
}