using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Workshop.Models
{
    public class Chat
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        [ForeignKey("UserReciver")]
        public string Receiver { get; set; }
        [ForeignKey("UserSender")]
        public string Sender { get; set; }
        public virtual IdentityUser UserSender { get; set; }
        public virtual IdentityUser UserReciver { get; set; }

        public virtual ICollection<Messages> Messages { get; set; }

        public Chat()
        {
            Messages = new HashSet<Messages>();
        }



    }
}
