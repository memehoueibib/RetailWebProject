using System.ComponentModel.DataAnnotations;

namespace RetailWebProject.Models
{
    public enum ProductCategory
    {
        Electronics,
        Clothing,
        Food,
        Home,
        Beauty
    }

    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Product name is required")]
        [StringLength(50, ErrorMessage = "Product name cannot exceed 50 characters")]
        [Display(Name = "Product Name")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Category is required")]
        public ProductCategory Category { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Range(0, 10000, ErrorMessage = "Price must be between 0 and 10,000")]
        [DataType(DataType.Currency)]
        [Display(Name = "Price ($)")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Release date is required")]
        [DataType(DataType.Date)]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
    }
}