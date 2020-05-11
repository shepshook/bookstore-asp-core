using System;
using Bookstore.Core.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.Web.Controllers
{
    public class AuthorController : Controller
    {
        private readonly IUnitOfWork _uow;
    
        public AuthorController(IUnitOfWork uow) => _uow = uow;

        [Route("authors")]
        public IActionResult List()
        {
            return View(_uow.AuthorRepository.All());
        }

        [Route("[controller]/[action]/{id:guid}")]
        public IActionResult Details(Guid id)
        {
            var author = _uow.AuthorRepository.Get(id);
            return author == null ? (IActionResult) NotFound() : View(author);
        }
    }
}