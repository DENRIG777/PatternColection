using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PatternColection.Models
{
    public class Pattern
    {
        [Display(Name ="Pattern Brand")]
        public string PatternBrand { get; set; }
        [Display(Name ="Pattern Name")]
        public string PatternName { get; set; }
        public string Size { get; set; }
        [Required]
        public string Description { get; set; }

        [NotMapped]
        public DateTime Created { get; set; }

        [NotMapped]
        [Display(Name ="Image")]
        public IFormFile ImageFile { get; set; }
        public byte[] ImageData { get; set; }
        public string ImageType { get; set; }

        public int Id { get; set; }

    }
}
