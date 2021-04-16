using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Workshop.Models
{
    public class WorkShop
    {
        public WorkShop()
        {
            Services = new List<Service>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

     
        public string Image { get; set; }
        public string Logo { get; set; }

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
     
        public virtual ICollection<Service> Services { get; set; }
        public virtual ICollection<WorkshopRate> WorkshopRates { get; set; }
    }
}