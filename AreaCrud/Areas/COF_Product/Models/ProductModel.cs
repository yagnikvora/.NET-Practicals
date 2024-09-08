using System.ComponentModel.DataAnnotations;

namespace AreaCrud.Areas.COF_Product.Models
{
    public class ProductModel
    {
        public int ProductID { get; set; }

        [Required(ErrorMessage = "Product Name is required")]
        [StringLength(100, ErrorMessage = "Product Name cannot be longer than 100 characters")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Product Price is required")]
        [Range(0.01, 999999.99, ErrorMessage = "Product Price must be between 0.01 and 999999.99")]
        public decimal ProductPrice { get; set; }

        [Required(ErrorMessage = "Product Code is required")]
        [StringLength(100, ErrorMessage = "Product Code cannot be longer than 100 characters")]
        public string ProductCode { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [StringLength(100, ErrorMessage = "Description cannot be longer than 100 characters")]
        public string Description { get; set; }
        public int UserID { get; set; }
    }
    public class UserDropDownModel
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
    }
}
