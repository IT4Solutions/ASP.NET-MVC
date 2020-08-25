using System.ComponentModel.DataAnnotations;

namespace IntroductionProject.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Display(Name ="Product Name")]
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public string Supplier { get; set; }
        public decimal Quantity { get; set; }

        [Display(Name ="Purchase Price")]
        public decimal PurchasePrice { get; set; }

        [Display(Name = "Sales Price")]
        public decimal SalesPrice { get; set; }
        public string Description { get; set; }
    }
}