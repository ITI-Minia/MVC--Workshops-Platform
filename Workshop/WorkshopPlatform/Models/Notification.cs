using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WorkshopPlatform.Models
{
    public class Notification
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Sender")]
        public string SenderID { get; set; }

        [ForeignKey("Receiver")]
        [Required]
        public string ReceiverId { get; set; }

        [Required]
        public string Type { get; set; }

        [ForeignKey("Content")]
        public int ContentId { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;

        public bool Unread { get; set; } = true;

        public virtual IdentityUser Receiver { get; set; }
        public virtual IdentityUser Sender { get; set; }
    }
}