using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Please enter movie's name")]
        public string Name { get; set; }

        [Display(Name = "Release Date")]
        [Required(ErrorMessage = "Release Date is required")]
        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }

        [Display(Name = "Number in Stock")]
        [Required(ErrorMessage = "Number in Stock is required")]
        [Range(1, 20)]
        public byte NumberInStock { get; set; }

        [Display(Name = "Genre")]
        [Required(ErrorMessage = "Genre is required") ]
        public int GenreId { get; set; }

        public Genre Genre { get; set; }
    }
}