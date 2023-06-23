using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using FinanceTaskOne.Constants;

namespace FinanceTaskOne.Models
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [Display(Name ="Product Name")]
        public string ProductName { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public double Price { get; set; }

        public int CategoryId { get;set; }
        [ForeignKey("CategoryId")]

        public Category Category { get; set; }

    }
}
