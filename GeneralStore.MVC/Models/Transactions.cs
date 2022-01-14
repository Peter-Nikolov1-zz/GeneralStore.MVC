using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GeneralStore.MVC.Models
{
    public class Transactions
    {
        [Key]
        public int TransactionId { get; set; }

        public virtual Product Product { get; set; }
        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }

        public virtual Customer Customer { get; set; }
        [ForeignKey(nameof(Customer))]
        public int CustomerId { get; set; }

        [Required]
        [Display(Name = "Date/Time of Transaction")]
        public DateTime TransactionDate { get; set; }

        [Required]
        [Display(Name = "Product Purchased")]
        public string ProductPurchased { get; set; }

        [Required]
        [Display(Name = "Price")]
        public double DollarAmount { get; set; }

        [Display(Name = "How Many?")]
        public int Quantity { get; set; }
    }
}