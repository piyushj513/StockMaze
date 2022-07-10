using System.ComponentModel.DataAnnotations;

namespace StockMaze.Models
{
    public class Vendor
    {
        [Key]
        public int vendorId { get; set; }

        [Required]
        [Display(Name = "Vendor Name")]
        public String vendorName { get; set; }

        [Required]
        [Display(Name = "Vendor Address")]
        public String vendorAddress { get; set; }

        [Required]
        [Display(Name = "Vendor Phone")]
        public String vendorPhone { get; set; }

        [Required]
        [Display(Name = "Vendor Email")]
        public String vendorEmail { get; set; }

    }
}
