using System;
using System.Linq;
using System.Linq.Expressions;
using Bookstore.Core.Entities;
using Bookstore.Core.Repositories;
using Bookstore.Web.Areas.Admin.Models;
using Bookstore.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BookController : Controller
    {
        private readonly IUnitOfWork _uow;

        public BookController(IUnitOfWork uow) => _uow = uow;

        [Route("[area]/books")]
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

        [HttpGet("[area]/[controller]/[action]/{id:guid}")]
        public IActionResult Edit(Guid id)
        {
            var book = _uow.BookRepository.Get(id);
            if (book == null)
                return NotFound();
            
            var model = new BookEditModel
            {
                Id = book.Id,
                Title = book.Title,
                Description = book.Description,
                PublicationDate = book.PublicationDate,
                PublisherId = book.Publisher?.Id.ToString() ?? "None",
                Rating = book.Rating,
                CoverImage = book.CoverImage
            };

            model.Publishers = _uow.PublisherRepository.All();

            return View(model);
        }

        [HttpPost("[area]/[controller]/[action]/{id:guid}")]
        public IActionResult Edit(BookEditModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var book = _uow.BookRepository.Get(model.Id);
            if (book == null)
                return NotFound();

            book.Title = model.Title;
            book.Description = model.Description;
            book.Publisher = Guid.TryParse(model.PublisherId, out var publisher) ? _uow.PublisherRepository.Get(publisher) : null;
            book.PublicationDate = model.PublicationDate;
            book.Rating = model.Rating;
            book.CoverImage = model.CoverImage;
            
            _uow.Commit();

            return RedirectToAction("List");
        }

        [Route("[area]/[controller]/[action]")]
        public IActionResult Create(BookEditModel model)
        {
            if (model == null || !ModelState.IsValid)
            {
                model = new BookEditModel();
                model.Publishers = _uow.PublisherRepository.All();
                return View(model);
            }

            var book = new Book
            {
                Title = model.Title,
                Description = model.Description,
                CoverImage = model.CoverImage,
                PublicationDate = model.PublicationDate,
                Rating = model.Rating,
                Publisher = Guid.TryParse(model.PublisherId, out var publisher) ? _uow.PublisherRepository.Get(publisher) : null
            };
            
            _uow.BookRepository.Insert(book);
            _uow.Commit();
            
            return RedirectToAction("List");
        }

        [Route("[area]/[controller]/[action]/{id:guid}")]
        public IActionResult EditAuthors(Guid id)
        {
            var book = _uow.BookRepository.Get(id);
            if (book == null)
                return NotFound();
            
            var model = new AuthorsEditModel
            {
                BookId = id,
                CurrentAuthors = book.BookAuthors.Select(x => x.Author)
            };
            model.OtherAuthors = _uow.AuthorRepository.All().Except(model.CurrentAuthors);
            
            return View(model);
        }

        [HttpPost("[area]/[controller]/[action]")]
        public IActionResult AddAuthor(AuthorsEditModel model)
        {
            if (!ModelState.IsValid)
                return View("EditAuthors", model);

            var book = _uow.BookRepository.Get(model.BookId);
            var author = _uow.AuthorRepository.Get(model.AuthorId);
            
            if (author != null && book != null)
            {
                book.BookAuthors.Add(new BookAuthor
                {
                    BookId = book.Id,
                    Book = book,
                    AuthorId = author.Id,
                    Author = author
                });
                _uow.BookRepository.Update(book);
                _uow.Commit();
            }

            return RedirectToAction("EditAuthors", new {id = model.BookId});
        }
        
        [HttpPost("[area]/[controller]/[action]")]
        public IActionResult DeleteAuthor(AuthorsEditModel model)
        {
            if (!ModelState.IsValid)
                return View("EditAuthors", model);
            
            var book = _uow.BookRepository.Get(model.BookId);
            var author = _uow.AuthorRepository.Get(model.AuthorId);
            
            if (author != null && book != null)
            {
                var ba = book.BookAuthors.SingleOrDefault(x => x.BookId == book.Id && x.AuthorId == author.Id);
                book.BookAuthors.Remove(ba);
                _uow.BookRepository.Update(book);
                _uow.Commit();
            }

            return RedirectToAction("EditAuthors", new {id = model.BookId});
        }

        [Route("[area]/[controller]/[action]/{id:guid}")]
        public IActionResult Delete(Guid id)
        {
            _uow.BookRepository.Delete(id);
            _uow.Commit();
            
            return RedirectToAction("List");
        }
    }
}