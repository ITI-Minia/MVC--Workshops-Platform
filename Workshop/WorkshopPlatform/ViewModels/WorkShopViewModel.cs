using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Workshop.ViewModel
{
    public class WorkshopViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Display(Name = "Workshop Imag")]
        public IFormFile Imagepath { get; set; }

        public string ImageUrl { get; set; }

        [Display(Name = "Workshop Logo")]
        public IFormFile Logopath { get; set; }

        public string LogoeUrl { get; set; }

        [Required]
        public bool Verified { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Government { get; set; }

        [Range(0, 5)]
        public double Rate { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }

        public virtual IdentityUser User { get; set; }

        public string RemoveImage { get; set; } = "false";
        public string RemoveLogo { get; set; } = "false";
    }
}