using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Workshop.Models
{
    public class Service
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int Price { get; set; }

        public string Description { get; set; }

        [Required]
        public bool Verified { get; set; }

        public string Image { get; set; }

        [ForeignKey("WorkShop")]
        public int WorkShopId { get; set; }

        public virtual WorkShop WorkShop { get; set; }

        public DateTime AddedIn { get; set; } = DateTime.Now;
    }
}