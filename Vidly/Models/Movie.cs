
using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Permissions;
using System.Web.Security;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public string Name { get; set; }
        public Genre Genre { get; set; }
        public byte GenreId { get; set; }
        [Display(Name="Release Date")]
        public DateTime ReleaseDate { get; set; }
        
        public DateTime DateAdded { get; set; }
        [Display(Name = "Number in stock")]
        [Range(1,20)]
        public byte NumberInStock { get; set; }
        public byte NumberAvailable { get; set; }
    }
}