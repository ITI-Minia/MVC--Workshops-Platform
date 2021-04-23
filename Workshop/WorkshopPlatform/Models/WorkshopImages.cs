using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Workshop.Models;

namespace WorkshopPlatform.Models
{
    public class WorkshopImages
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        public string path { get; set; }

        [ForeignKey("WorkShop")]
        public int WorkShopId { get; set; }

        public virtual WorkShop WorkShop { get; set; }
    }
}