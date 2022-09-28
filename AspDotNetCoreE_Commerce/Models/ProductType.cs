using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AspDotNetCoreE_Commerce.Models
{
    public class ProductType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Product Type")]
        public string Name { get; set; }
    }
}
