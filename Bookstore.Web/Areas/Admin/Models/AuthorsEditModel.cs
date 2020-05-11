using System;
using System.Collections.Generic;
using Bookstore.Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.Web.Areas.Admin.Models
{
    public class AuthorsEditModel
    {
        [HiddenInput] 
        public Guid BookId { get; set; }
        
        [HiddenInput]
        public Guid AuthorId { get; set; }
        
        public IEnumerable<Author> CurrentAuthors { get; set; }
        public IEnumerable<Author> OtherAuthors { get; set; }
    }
}