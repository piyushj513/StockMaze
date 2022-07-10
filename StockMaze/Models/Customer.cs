using System.ComponentModel.DataAnnotations;

namespace StockMaze.Models
{
    public class Customer
    {

        [Key]
        public int customerId { get; set; }

        [Required]
        [Display(Name = "Customer Name")]
        public String customerName { get; set; }

        [Required]
        [Display(Name = "Customer Address")]
        public String customerAddress { get; set; }

        [Required]
        [Display(Name = "Customer Phone")]
        public String customerPhone { get; set; }

        [Required]
        [Display(Name = "Customer Email")]
        public String customerEmail { get; set; }

    }
}
