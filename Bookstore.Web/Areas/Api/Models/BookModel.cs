using System;
using System.Collections.Generic;

namespace Bookstore.Web.Areas.Api.Models
{
    public class BookModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? PublicationDate { get; set; }
        public double? Rating { get; set; }
        public string CoverImage { get; set; }
        public string Publisher { get; set; }
        public IEnumerable<string> Authors { get; set; }
    }
}