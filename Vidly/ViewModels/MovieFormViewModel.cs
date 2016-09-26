using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }

        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Release Date")]
        [Required(ErrorMessage = "Release Date is required")]
        public DateTime? ReleaseDate { get; set; }
        
        [Display(Name = "Number in Stock")]
        [Required(ErrorMessage = "Number in Stock is required")]
        [Range(1, 20)]
        public byte NumberInStock { get; set; }

        [Display(Name = "Genre")]
        [Required(ErrorMessage = "Genre is required")]
        public int? GenreId { get; set; }
        
        public string Title
        {
            get
            {
                if (Id != 0)
                     return "Edit Movie";
 
                 return "New Movie";
            }
        }

        public MovieFormViewModel()
        {
            Id = 0;
        }

        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            GenreId = movie.GenreId;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
        }
    }
}