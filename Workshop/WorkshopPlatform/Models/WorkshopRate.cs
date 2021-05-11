using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Workshop.Models
{
    public class WorkshopRate
    {
        public DateTime Date { get; set; } = DateTime.Now;
        public string Review { get; set; }

        [Range(0, 5)]
        public double? Rate { get; set; }

        [ForeignKey("UserProfile")]
        public int UserProfileId { get; set; }

        public virtual UserProfile UserProfile { get; set; }

        [ForeignKey("WorkShop")]
        public int WorkShopId { get; set; }

        public virtual WorkShop WorkShop { get; set; }
    }
}