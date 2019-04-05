using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.DTOs
{
    public class MovieDto
    {
        public int Id { get; set; }
        
        [StringLength(200)]
        public string Name { get; set; }
        
        public GenreDto Genre { get; set; }

        public byte GenreId { get; set; }
        
        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }
       
        [Range(1, 20)]
        public byte NumberInStock { get; set; }
    }
}