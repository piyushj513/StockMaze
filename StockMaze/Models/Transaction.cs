using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockMaze.Models
{
    public class Transaction
    {
        [Key]
        public int transactionId { get; set; }

        [Required]
        [Display(Name = "Transaction Date")]
        public DateTime TransactionDate { get; set; }

        [Required]
        [Display(Name = "Transaction Name")]
        public String TransactionName { get; set; }

        [Required]
        [Display(Name = "Transaction Description")]
        public String TransactionDesc { get; set; }
        [Display(Name = "Invoice Ref")]
        public String TransactionInvoiceRef { get; set; }

        [Required]
        [ForeignKey("productId")]
		[Display(Name ="Product Id")]
        public int ProductId { get; set; }

        [Display(Name = "Product Name")]
        public String ProductName { get; set; }

        [Required]
        [Display(Name = "Stock In")]
        public int InventoryInUnit { get; set; }

        [Required]
        [Display(Name = "Stock Out")]
        public int InventoryOutUnit { get; set; }

        [Required]
        [Display(Name = "Balance Units")]
        public int InventoryBalUnit { get; set; }
        [Display(Name = "Cost Per Product")]
        public Double ProductCostPricePU { get; set; }
        [Display(Name = "Selling Price ")]
        public Double ProductSellingPricePU { get; set; }
        [Display(Name = "Total Price")]
        public Double InvBalCostPriceTotal { get; set; }
    }
}