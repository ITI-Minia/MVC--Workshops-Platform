using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Workshop.Models
{
    public class Messages
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Key]
        public int Id { get; set; }
        [ForeignKey("Chat")]
        public int ChatId { get; set; }
        public string Text { get; set; }
        public DateTime When  { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        public virtual Chat Chat { get; set; }
        public virtual IdentityUser User { get; set; }
        public Messages()
        {
            When = DateTime.Now;
        }
    }
}
