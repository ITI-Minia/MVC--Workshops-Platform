using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Workshop.Models;

namespace WorkshopPlatform.Models
{
    public class UserServices
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        [ForeignKey("User")]
        [Required]
        public string UserId { get; set; }

        public virtual IdentityUser User { get; set; }

        [ForeignKey("Service")]
        [Required]
        public int ServiceId { get; set; }

        public virtual Service Service { get; set; }

        [Required]
        public DateTime Date { get; set; } = DateTime.Now;

        [Required]
        public bool Finished { get; set; } = false;
    }
}