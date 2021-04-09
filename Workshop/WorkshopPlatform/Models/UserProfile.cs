using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Workshop.Models
{
    public class UserProfile
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string CarModel { get; set; }
        public string CarBrand { get; set; }

        public string Image { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Government { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }

        public virtual IdentityUser User { get; set; }
        public virtual ICollection<WorkshopRate> WorkshopRates { get; set; }
    }
}