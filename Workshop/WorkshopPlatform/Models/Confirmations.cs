using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WorkshopPlatform.Common.Enums;

namespace Workshop.Models
{
    public class Confirmations
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        [Required]
        public ConfirmationType Type { get; set; }       
        public string Message { get; set; }
        [Required]
        public bool Confirmed { get; set; }
        [Required]
        public DateTime CreationTime { get; set; }

        [Required]
        public int ConfirmedEntityId { get; set; }
        
    }
}
