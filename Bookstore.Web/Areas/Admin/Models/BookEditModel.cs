using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Bookstore.Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.Web.Areas.Admin.Models
{
    public class BookEditModel
    {
        [HiddenInput]
        public Guid Id { get; set; }
        
        [Required(ErrorMessage = "Title is required")]
        [StringLength(1024, ErrorMessage = "Max length is 1024")]
        public string Title { get; set; }
        
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        
        [DisplayName("Cover image URL")]
        [DataType(DataType.ImageUrl)]
        public string CoverImage { get; set; }

        [DisplayName("Publisher")]
        public string PublisherId { get; set; }

        [DisplayName("Publication date")]
        [DataType(DataType.Date)]
        public DateTime? PublicationDate { get; set; }
        
        [Range(0, 5, ErrorMessage = "Rating must be between 0 and 5")]
        public double? Rating { get; set; }
        
        
        public IEnumerable<Publisher> Publishers { get; set; }
    }
}