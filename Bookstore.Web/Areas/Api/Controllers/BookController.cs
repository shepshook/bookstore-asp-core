using System;
using System.Collections.Generic;
using System.Linq;
using Bookstore.Core.Entities;
using Bookstore.Core.Repositories;
using Bookstore.Web.Areas.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.Web.Areas.Api.Controllers
{
    [Area("Api")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IUnitOfWork _uow;

        public BookController(IUnitOfWork uow) => _uow = uow;
        
        [HttpGet("[area]/books")]
        public IEnumerable<BookModel> List()
        {
            return _uow.BookRepository.All().Select(Map);
        }

        [HttpGet("[area]/books/{id:guid}")]
        public ActionResult<BookModel> Get(Guid id)
        {
            var book = _uow.BookRepository.Get(id);
            if (book == null)
                return NotFound();

            return Ok(Map(book));
        }
    
        // Map Book object to serializable BookModel
        private BookModel Map(Book book)
        {
            return new BookModel
            {
                Id = book.Id,
                Title = book.Title,
                Description = book.Description,
                CoverImage = book.CoverImage,
                Rating = book.Rating,
                PublicationDate = book.PublicationDate,
                Publisher = book.Publisher?.Name,
                Authors = book.BookAuthors.Select(x => x.Author.ToString())
            };
        }
    }
}