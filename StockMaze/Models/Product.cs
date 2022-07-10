using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockMaze.Models
{
    public class Product
        {
            [Key]
            public int productId { get; set; }

            [Required]
            [Display(Name = "Product Name")]
            public String productName { get; set; }

            [Required]
            [Display(Name = "Product Desc")]
            public String productDesc { get; set; }

            [Required]
            [ForeignKey("vendorId")]
            [Display(Name = "Vendor Id")]
            public int vendorId { get; set; }


            [Display(Name = "Vendor Name")]
            public String vendorName { get; set; }

            [Required]
            [Display(Name = "Product Cost")]
            public String productCost { get; set; }

            [Required]
            [Display(Name = "Product Margin")]
            public String productMargin { get; set; }

            [Required]
            [Display(Name = "Selling Price")]
            public String productSellingPrice { get; set; }

        }
    }
